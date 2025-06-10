//@CodeCopy

#if IDINT_ON
global using IdType = System.Int32;
#elif IDLONG_ON
    global using IdType = System.Int64;
#elif IDGUID_ON
    global using IdType = System.Guid;
#else
global using IdType = System.Int32;
#endif
global using Common = eVaccinationPass.Common;
global using CommonModules = eVaccinationPass.Common.Modules;
global using eVaccinationPass.Common.Extensions;
global using CommonStaticLiterals = eVaccinationPass.Common.StaticLiterals;
global using TemplatePath = eVaccinationPass.Common.Modules.Template.TemplatePath;
