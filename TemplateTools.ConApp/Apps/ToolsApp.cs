﻿//@CodeCopy

using System.Collections.Generic;
using TemplateTools.Logic;
using TemplateTools.Logic.Git;

namespace TemplateTools.ConApp.Apps
{
    /// <summary>
    /// Represents the main application class for the ToolsApp.
    /// </summary>
    public partial class ToolsApp : ConsoleApplication
    {
        #region Class-Constructors
        /// <summary>
        /// Initializes the <see cref="Program"/> class.
        /// This static constructor sets up the necessary properties for the program.
        /// </remarks>
        static ToolsApp()
        {
            ClassConstructing();
            ClassConstructed();
        }
        /// <summary>
        /// This method is called during the construction of the class.
        /// </summary>
        static partial void ClassConstructing();
        /// <summary>
        /// Represents a method that is called when a class is constructed.
        /// </summary>
        static partial void ClassConstructed();
        #endregion Class-Constructors

        #region Instance-Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="Application"/> class.
        /// </summary>
        public ToolsApp()
        {
            Constructing();
            Constructed();
        }
        /// <summary>
        /// This method is called during the construction of the object.
        /// </summary>
        partial void Constructing();
        /// <summary>
        /// This method is called when the object is constructed.
        /// </summary>
        partial void Constructed();
        #endregion Instance-Constructors

        #region properties
        private string[] AppArgs { get; set; } = [];
        #endregion properties

        #region overrides
        /// <summary>
        /// Creates an array of menu items for the application menu.
        /// </summary>
        /// <returns>An array of MenuItem objects representing the menu items.</returns>
        protected override MenuItem[] CreateMenuItems()
        {
            var mnuIdx = 0;
            var menuItems = new List<MenuItem>
            {
                new()
                {
                    Key = "----",
                    Text = new string('-', 65),
                    Action = (self) => { },
                    ForegroundColor = ConsoleColor.DarkGreen,
                },

                new()
                {
                    Key = $"{++mnuIdx}",
                    Text = ToLabelText("Path", "Change solution path"),
                    Action = (self) => ChangeSolutionPath(),
                },

                new()
                {
                    Key = "----",
                    Text = new string('-', 65),
                    Action = (self) => { },
                    ForegroundColor = ConsoleColor.DarkGreen,
                },

                new()
                {
                    Key = (++mnuIdx).ToString(),
                    OptionalKey = "copier",
                    Text = ToLabelText("Copier", "Copy this solution to a domain solution"),
                    Action = (self) => new CopierApp().Run(AppArgs),
                },
                new()
                {
                    Key = (++mnuIdx).ToString(),
                    OptionalKey = "preprocessor",
                    Text = ToLabelText("Preprocessor", "Setting defines for project options"),
                    Action = (self) => new PreprocessorApp().Run(AppArgs),
                },
                new()
                {
                    Key = (++mnuIdx).ToString(),
                    OptionalKey = "codegenerator",
                    Text = ToLabelText("CodeGenerator", "Generate code for this solution"),
                    Action = (self) => new CodeGeneratorApp().Run(AppArgs),
                },
                new()
                {
                    Key = string.Empty,
                    OptionalKey = "codemanager",
                    IsDisplayed = false,
                    Text = string.Empty,
                    Action = (self) => new CodeManagerApp().Run(AppArgs),
                },
                new()
                {
                    Key = (++mnuIdx).ToString(),
                    OptionalKey = "synchronizer",
                    Text = ToLabelText("Synchronization", "Matches a project with the template"),
                    Action = (self) => new SynchronizationApp().Run(AppArgs),
                },
                new()
                {
                    Key = string.Empty,
                    OptionalKey = "partialsynchronizer",
                    IsDisplayed = false,
                    Text = string.Empty,
                    Action = (self) => new PartialSynchronizationApp(SolutionPath, SourcePath).Run(AppArgs),
                },
                new()
                {
                    Key = (++mnuIdx).ToString(),
                    OptionalKey = "cleanup",
                    Text = ToLabelText("Cleanup", "Deletes the temporary directories"),
                    Action = (self) => new CleanupApp().Run(AppArgs),
                },
            };
            return [.. menuItems.Union(CreateExitMenuItems())];
        }

        /// <summary>
        /// Prints the header for the PlantUML application.
        /// </summary>
        /// <param name="sourcePath">The path of the solution.</param>
        protected override void PrintHeader()
        {
            List<KeyValuePair<string, object>> headerParams = [new("Solution path:", SolutionPath)];

            base.PrintHeader("Template Tools", [.. headerParams]);
        }
        /// <summary>
        /// Performs any necessary setup or initialization before running the application.
        /// </summary>
        /// <param name="args">The command-line arguments passed to the application.</param>
        protected override void BeforeRun(string[] args)
        {
            var convertedArgs = ConvertArgs(args);
            var appArgs = new List<string>();

            foreach (var arg in convertedArgs)
            {
                if (arg.Key.Equals(nameof(HomePath), StringComparison.OrdinalIgnoreCase))
                {
                    HomePath = arg.Value;
                }
                else if (arg.Key.Equals(nameof(UserPath), StringComparison.OrdinalIgnoreCase))
                {
                    UserPath = arg.Value;
                }
                else if (arg.Key.Equals(nameof(ReposPath), StringComparison.OrdinalIgnoreCase))
                {
                    ReposPath = arg.Value;
                }
                else if (arg.Key.Equals(nameof(SourcePath), StringComparison.OrdinalIgnoreCase))
                {
                    SourcePath = arg.Value;
                }
                else if (arg.Key.Equals(nameof(SolutionPath), StringComparison.OrdinalIgnoreCase))
                {
                    SolutionPath = arg.Value;
                }
                else if (arg.Key.Equals("AppArg", StringComparison.OrdinalIgnoreCase))
                {
                    foreach (var item in arg.Value.ToLower().Split(','))
                    {
                        CommandQueue.Enqueue(item);
                    }
                }
                else
                {
                    appArgs.Add($"{arg.Key}={arg.Value}");
                }
            }
            AppArgs = [.. appArgs];
            base.BeforeRun(AppArgs);
        }
        protected override void AfterRun()
        {
            PrintHeader();

            ConsoleColor foregroundColor = ForegroundColor;
            ForegroundColor = ConsoleColor.Green;
            PrintLine("Application finished successfully.");
            ForegroundColor = foregroundColor;

            base.AfterRun();
        }
        #endregion overrides

        #region app methods
        /// <summary>
        /// Deletes all generated files from the solution path.
        /// </summary>
        internal void DeleteGeneratedFiles()
        {
            PrintHeader();
            StartProgressBar();
            Console.WriteLine("Delete all generated files...");
            Generator.DeleteGeneratedFiles(SolutionPath);
            Console.WriteLine("Delete all generated files ignored from git...");
            GitIgnoreManager.DeleteIgnoreEntries(SolutionPath);
        }
        #endregion app methods
    }
}

