﻿//@CodeCopy
namespace eVaccinationPass.WebApi.Models
{
    public partial class QueryParams
    {
        public string Filter { get; set; } = string.Empty;
        public string[] Values { get; set; } = [];
    }
}
