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
global using CommonEnums = eVaccinationPass.Common.Enums;
global using CommonContracts = eVaccinationPass.Common.Contracts;
global using CommonModels = eVaccinationPass.Common.Models;
global using CommonModules = eVaccinationPass.Common.Modules;
global using eVaccinationPass.Common.Extensions;
global using System.ComponentModel.DataAnnotations;
global using System.ComponentModel.DataAnnotations.Schema;
global using Microsoft.EntityFrameworkCore;

