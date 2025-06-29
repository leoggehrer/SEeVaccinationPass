﻿//@CodeCopy
#if IDINT_ON
global using IdType = System.Int32;
#elif IDLONG_ON
global using IdType = System.Int64;
#elif IDGUID_ON
global using IdType = System.Guid;
#else
global using IdType = System.Int32;
#endif

global using CommonContracts = eVaccinationPass.Common.Contracts;
global using eVaccinationPass.Common.Extensions;
