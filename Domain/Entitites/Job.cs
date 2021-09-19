using System;

namespace API.Entitites
{
    public record Job
    {
        public int ID { get; init; }
        public string Name { get; init; }
        public int CompanyID { get; init; }
        public int[] TagIDs { get; init; }
        public string Address { get; init; }
        public string SalaryRange { get; init; }
        public string TopReasons { get; init; }
        public string JobDescription { get; init; }
        public string SkillAndExp { get; init; }
        public string WhyWorkingHere { get; init; }
    }
}