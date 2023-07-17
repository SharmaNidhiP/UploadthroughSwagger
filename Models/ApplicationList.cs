using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

public class ApplicationList
{
    [Key]
    [NotNull]
    public required string ApplicationId { get; set; }
    public string? ApplicationLabel { get; set; }
    public string? Global { get; set; }
    public string? ITLandscape { get; set; }
    public string? ScatterView { get; set; }
    public string? Size { get; set; }
    public string? ProjectPortfolio { get; set; }
    public string? CreationYear { get; set; }
    public string? DecommissioningPlan { get; set; }
    public string? ITDomain { get; set; }
    public string? ITSubDomain { get; set; }
    public string? BusinessDomain { get; set; }
    public string? BusinessProcessLevel1 { get; set; }
    public string? BusinessProcessLevel2 { get; set; }
    public string? MainTechnologies { get; set; }
    public string? SolutionMix { get; set; }
    public string? PackageCategory { get; set; }
    public string? NumberOfUsers { get; set; }
    public string? ReadyForAssessment { get; set; }
    public string? Scope { get; set; }
    public string? NicheProgrammingLanguage { get; set; }
    public string? DecommissioningType { get; set; }
    public string? Package { get; set; }
    public string? SMAC { get; set; }
    public string? Regulatory { get; set; }
    public string? Deployment { get; set; }
    public string? IntDeliveryModel { get; set; }
    public string? ExtDeliveryModel { get; set; }
    public string? DRP { get; set; }
    public string? RedundantApplications { get; set; }
    public string? DatabaseManagementSystem { get; set; }
    public string? ApplicationServer { get; set; }
    public string? TargetApplication { get; set; }
    public string? HostingMode { get; set; }
    public string? CloudTargetInfrastructure { get; set; }
    public string? CloudMigrationPath { get; set; }
    public string? CloudMigrationComplexity { get; set; }
    public string? CloudServiceModel { get; set; }
    public string? Rationale { get; set; }
    public string? PublicCloudBlocker { get; set; }
    public string? CloudMigrationWave { get; set; }
    public string? MainOSInProduction { get; set; }
    public string? MainOS { get; set; }
    public string? MainProdServersLocations { get; set; }
    public string? RationalizationDestiny { get; set; }
    public string? RationalizationCategory { get; set; }
    public string? RationalizationType { get; set; }
    public string? CandidateToGHOSTSRV { get; set; }
    public string? CandidateToPSMutualization { get; set; }
    public string? FixedSize { get; set; }
    public string? TotalServers { get; set; }
    public string? ProductionServers { get; set; }
    public string? ProductionVirtualServers { get; set; }
    public string? ProductionPhysicalServers { get; set; }
    public string? NonProductionServers { get; set; }
    public string? NonProductionVirtualServers { get; set; }
    public string? AllocatedDiskSpace { get; set; }
    public string? UsedDiskSpace { get; set; }
    public string? FTE { get; set; }
    public string? FTEInternal { get; set; }
    public string? FTEExternal { get; set; }
    public string? FTEExternalFP { get; set; }
    public string? FTEMajorChanges { get; set; }
    public string? FTEMinorChanges { get; set; }
    public string? FTEProblems { get; set; }
    public string? FTEServiceRequests { get; set; }
    public string? TCO { get; set; }
    public string? TotalStaffCost { get; set; }
    public string? InternalStaffCost { get; set; }
    public string? ExternalStaffCost { get; set; }
    public string? TotalInfrastructureCost { get; set; }
    public string? HardwareCost { get; set; }
    public string? LicenseCost { get; set; }
    public string? ManagedServicesCost { get; set; }
    public string? ExternalFPStaffCost { get; set; }
    public string? MajorChangesCost { get; set; }
    public string? MinorChangesCost { get; set; }
    public string? ProblemsCost { get; set; }
    public string? ServiceRequestsCost { get; set; }
    public string? NumberOfMinorChanges { get; set; }
    public string? NumberOfProblems { get; set; }
    public string? NumberOfServiceRequests { get; set; }
    public string? BacklogMinorChanges { get; set; }
    public string? BacklogProblems { get; set; }
    public string? BacklogServiceRequests { get; set; }
    public string? HAETProblems { get; set; }
    public string? NumberOfMajorReleases { get; set; }
    public string? NumberOfITPPerYear { get; set; }
    public string? CloudMigrationComplexitySize { get; set; }
    public string? CostPerYearAWS { get; set; }
    public string? CostPerYearAzure { get; set; }
    public string? TCFKgCO2ePerYear { get; set; }
    public string? COMPUTE { get; set; }
    public string? COMPUTEMANUF { get; set; }
    public string? COMPUTERUN { get; set; }
    public string? COMPUTERUNMarketBased { get; set; }
    public string? OPERATINGMODEL { get; set; }
    public string? Criticality { get; set; }
    public string? Dynamism { get; set; }
    public string? ServiceLevel { get; set; }
    public string? FunctionalComplexity { get; set; }
    public string? Usage { get; set; }
    public string? BusinessDifferentiation { get; set; }
    public string? DemandQuality { get; set; }
    public string? BusinessNeedsAdequacy { get; set; }
    public string? RequiredTTM { get; set; }
    public string? DevOpsMaturity { get; set; }
    public string? QOS { get; set; }
    public string? MaxAcceptableDowntime { get; set; }
    public string? TechnicalObsolescence { get; set; }
    public string? CodeQuality { get; set; }
    public string? Maintainability { get; set; }
    public string? SourceCodeAvailability { get; set; }
    public string? LevelOfIntegration { get; set; }
    public string? PackageCustomization { get; set; }
    public string? AgeOfApplication { get; set; }
    public string? SuppliersDependency { get; set; }
    public string? GlobalOffshoreRatio { get; set; }
    public string? InternalOffshoreRatio { get; set; }
    public string? ExternalOffshoreRatio { get; set; }
    public string? ChangeIndex { get; set; }
    public string? ITDigitalReadiness { get; set; }
    public string? WebCollectCompleteness { get; set; }
    public string? LevelOfRobustness { get; set; }
    public string? OSObsolescence { get; set; }
    public string? VirtualizationRate { get; set; }
    public string? DiskSpaceUsed { get; set; }
    public string? ProductionServerRate { get; set; }
    public string? GlobalRisk { get; set; }
    public string? SecurityRisk { get; set; }
    public string? InstabilityRisk { get; set; }
    public string? MaintainabilityRisk { get; set; }
    public string? TechnicalObsolescenceRisk { get; set; }
    public string? VolatilityRisk { get; set; }
    public string? PeopleDependencyRisk { get; set; }
    public string? SuppliersDependencyRisk { get; set; }
    public string? LicensePortability { get; set; }
    public string? CloudCompatibleArchitecture { get; set; }
    public string? DataResidency { get; set; }
    public string? DataClassification { get; set; }
    public string? VirtualizationStatus { get; set; }
    public string? RTO { get; set; }
    public string? RPO { get; set; }
    public string? ResponseTimeLatencyRequirement { get; set; }
    public string? Security { get; set; }
    public string? SecurityCompliance { get; set; }
    public string? Availability { get; set; }
    public string? Integrity { get; set; }
    public string? Confidentiality { get; set; }
    public string? Proof { get; set; }
    public string? RationalizationSolutionQuality { get; set; }
    public string? RationalizationTCOLevel { get; set; }
    public string? CyberSecurityScore { get; set; }
    public string? CarbonIntensityRate { get; set; }
    public string? PUERate { get; set; }
    public string? RenewableEnergyRate { get; set; }
    public string? HostingRate { get; set; }
    public string? HostingRateRECIncluded { get; set; }
    public string? ManufacturingRate { get; set; }
    public string? CloudRate { get; set; }
}
