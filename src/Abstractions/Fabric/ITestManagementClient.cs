// MIT License
// Copyright (c) 2021 Marco Stolze

namespace MS.Extensions.Fabric
{
    public interface ITestManagementClient
    {
        //Task StartPartitionDataLossAsync(Guid operationId, PartitionSelector partitionSelector, DataLossMode dataLossMode);
        //Task StartPartitionDataLossAsync(Guid operationId, PartitionSelector partitionSelector, DataLossMode dataLossMode, CancellationToken cancellationToken);
        //Task StartPartitionDataLossAsync(Guid operationId, PartitionSelector partitionSelector, DataLossMode dataLossMode, TimeSpan operationTimeout);
        //Task StartPartitionDataLossAsync(Guid operationId, PartitionSelector partitionSelector, DataLossMode dataLossMode, TimeSpan operationTimeout, CancellationToken cancellationToken);
        //[Obsolete("This api is deprecated, use StartPartitionDataLossAsync instead.  StartPartitionDataLossAsync requires the FaultAnalysisService")]
        //Task<InvokeDataLossResult> InvokeDataLossAsync(PartitionSelector partitionSelector, DataLossMode dataLossMode);
        //[Obsolete("This api is deprecated, use StartPartitionDataLossAsync instead.  StartPartitionDataLossAsync requires the FaultAnalysisService")]
        //Task<InvokeDataLossResult> InvokeDataLossAsync(PartitionSelector partitionSelector, DataLossMode dataLossMode, CancellationToken cancellationToken);
        //[Obsolete("This api is deprecated, use StartPartitionDataLossAsync instead.  StartPartitionDataLossAsync requires the FaultAnalysisService")]
        //Task<InvokeDataLossResult> InvokeDataLossAsync(PartitionSelector partitionSelector, DataLossMode dataLossMode, TimeSpan operationTimeout);
        //[Obsolete("This api is deprecated, use StartPartitionDataLossAsync instead.  StartPartitionDataLossAsync requires the FaultAnalysisService")]
        //Task<InvokeDataLossResult> InvokeDataLossAsync(PartitionSelector partitionSelector, DataLossMode dataLossMode, TimeSpan operationTimeout, CancellationToken cancellationToken);
        //Task StartPartitionQuorumLossAsync(Guid operationId, PartitionSelector partitionSelector, QuorumLossMode quorumLossMode, TimeSpan quorumLossDuration);
        //Task StartPartitionQuorumLossAsync(Guid operationId, PartitionSelector partitionSelector, QuorumLossMode quorumLossMode, TimeSpan quorumLossDuration, CancellationToken cancellationToken);
        //Task StartPartitionQuorumLossAsync(Guid operationId, PartitionSelector partitionSelector, QuorumLossMode quorumLossMode, TimeSpan quorumLossDuration, TimeSpan operationTimeout);
        //Task StartPartitionQuorumLossAsync(Guid operationId, PartitionSelector partitionSelector, QuorumLossMode quorumlossMode, TimeSpan quorumlossDuration, TimeSpan operationTimeout, CancellationToken cancellationToken);
        //[Obsolete("This api is deprecated, use StartPartitionQuorumLossAsync instead.  StartPartitionQuorumLossAsync requires the FaultAnalysisService")]
        //Task<InvokeQuorumLossResult> InvokeQuorumLossAsync(PartitionSelector partitionSelector, QuorumLossMode quorumLossMode, TimeSpan quorumLossDuration);
        //[Obsolete("This api is deprecated, use StartPartitionQuorumLossAsync instead.  StartPartitionQuorumLossAsync requires the FaultAnalysisService")]
        //Task<InvokeQuorumLossResult> InvokeQuorumLossAsync(PartitionSelector partitionSelector, QuorumLossMode quorumLossMode, TimeSpan quorumLossDuration, CancellationToken cancellationToken);
        //[Obsolete("This api is deprecated, use StartPartitionQuorumLossAsync instead.  StartPartitionQuorumLossAsync requires the FaultAnalysisService")]
        //Task<InvokeQuorumLossResult> InvokeQuorumLossAsync(PartitionSelector partitionSelector, QuorumLossMode quorumLossMode, TimeSpan quorumLossDuration, TimeSpan operationTimeout);
        //[Obsolete("This api is deprecated, use StartPartitionQuorumLossAsync instead.  StartPartitionQuorumLossAsync requires the FaultAnalysisService")]
        //Task<InvokeQuorumLossResult> InvokeQuorumLossAsync(PartitionSelector partitionSelector, QuorumLossMode quorumlossMode, TimeSpan quorumlossDuration, TimeSpan operationTimeout, CancellationToken cancellationToken);
        //Task StartPartitionRestartAsync(Guid operationId, PartitionSelector partitionSelector, RestartPartitionMode restartPartitionMode);
        //Task StartPartitionRestartAsync(Guid operationId, PartitionSelector partitionSelector, RestartPartitionMode restartPartitionMode, CancellationToken cancellationToken);
        //Task StartPartitionRestartAsync(Guid operationId, PartitionSelector partitionSelector, RestartPartitionMode restartPartitionMode, TimeSpan operationTimeout);
        //Task StartPartitionRestartAsync(Guid operationId, PartitionSelector partitionSelector, RestartPartitionMode restartPartitionMode, TimeSpan operationTimeout, CancellationToken cancellationToken);
        //[Obsolete("This api is deprecated, use StartPartitionRestartAsync instead.  StartPartitionRestartAsync requires the FaultAnalysisService")]
        //Task<RestartPartitionResult> RestartPartitionAsync(PartitionSelector partitionSelector, RestartPartitionMode restartPartitionMode);
        //[Obsolete("This api is deprecated, use StartPartitionRestartAsync instead.  StartPartitionRestartAsync requires the FaultAnalysisService")]
        //Task<RestartPartitionResult> RestartPartitionAsync(PartitionSelector partitionSelector, RestartPartitionMode restartPartitionMode, CancellationToken cancellationToken);
        //[Obsolete("This api is deprecated, use StartPartitionRestartAsync instead.  StartPartitionRestartAsync requires the FaultAnalysisService")]
        //Task<RestartPartitionResult> RestartPartitionAsync(PartitionSelector partitionSelector, RestartPartitionMode restartPartitionMode, TimeSpan operationTimeout);
        //[Obsolete("This api is deprecated, use StartPartitionRestartAsync instead.  StartPartitionRestartAsync requires the FaultAnalysisService")]
        //Task<RestartPartitionResult> RestartPartitionAsync(PartitionSelector partitionSelector, RestartPartitionMode restartPartitionMode, TimeSpan operationTimeout, CancellationToken cancellationToken);
        //Task<PartitionDataLossProgress> GetPartitionDataLossProgressAsync(Guid operationId);
        //Task<PartitionDataLossProgress> GetPartitionDataLossProgressAsync(Guid operationId, TimeSpan timeout);
        //Task<PartitionDataLossProgress> GetPartitionDataLossProgressAsync(Guid operationId, CancellationToken cancellationToken);
        //Task<PartitionDataLossProgress> GetPartitionDataLossProgressAsync(Guid operationId, TimeSpan timeout, CancellationToken cancellationToken);
        //Task<PartitionQuorumLossProgress> GetPartitionQuorumLossProgressAsync(Guid operationId);
        //Task<PartitionQuorumLossProgress> GetPartitionQuorumLossProgressAsync(Guid operationId, TimeSpan timeout);
        //Task<PartitionQuorumLossProgress> GetPartitionQuorumLossProgressAsync(Guid operationId, CancellationToken cancellationToken);
        //Task<PartitionQuorumLossProgress> GetPartitionQuorumLossProgressAsync(Guid operationId, TimeSpan timeout, CancellationToken cancellationToken);
        //Task<PartitionRestartProgress> GetPartitionRestartProgressAsync(Guid operationId);
        //Task<PartitionRestartProgress> GetPartitionRestartProgressAsync(Guid operationId, TimeSpan timeout);
        //Task<PartitionRestartProgress> GetPartitionRestartProgressAsync(Guid operationId, CancellationToken cancellationToken);
        //Task<PartitionRestartProgress> GetPartitionRestartProgressAsync(Guid operationId, TimeSpan timeout, CancellationToken cancellationToken);
        //Task<TestCommandStatusList> GetTestCommandStatusListAsync(TimeSpan operationTimeout, CancellationToken cancellationToken);
        //Task<TestCommandStatusList> GetTestCommandStatusListAsync(CancellationToken cancellationToken);
        //Task<TestCommandStatusList> GetTestCommandStatusListAsync(TimeSpan operationTimeout);
        //Task<TestCommandStatusList> GetTestCommandStatusListAsync(TestCommandStateFilter stateFilter, TimeSpan operationTimeout, CancellationToken cancellationToken);
        //Task<TestCommandStatusList> GetTestCommandStatusListAsync(TestCommandTypeFilter typeFilter, TimeSpan operationTimeout, CancellationToken cancellationToken);
        //Task<TestCommandStatusList> GetTestCommandStatusListAsync(TestCommandStateFilter stateFilter, TestCommandTypeFilter typeFilter, TimeSpan operationTimeout, CancellationToken cancellationToken);
        //Task CancelTestCommandAsync(Guid operationId, bool force);
        //Task CancelTestCommandAsync(Guid operationId, bool force, TimeSpan timeout);
        //Task CancelTestCommandAsync(Guid operationId, bool force, CancellationToken cancellationToken);
        //Task CancelTestCommandAsync(Guid operationId, bool force, TimeSpan timeout, CancellationToken cancellationToken);
        //Task StartNodeTransitionAsync(NodeTransitionDescription description, TimeSpan operationTimeout, CancellationToken token);
        //Task<NodeTransitionProgress> GetNodeTransitionProgressAsync(Guid operationId, TimeSpan timeout, CancellationToken cancellationToken);
        //Task CleanTestStateAsync();
        //Task CleanTestStateAsync(TimeSpan operationTimeout, CancellationToken token);
        //Task ValidateApplicationAsync(Uri applicationName, TimeSpan maximumStabilizationTimeout);
        //Task ValidateApplicationAsync(Uri applicationName, TimeSpan maximumStabilizationTimeout, CancellationToken token);
        //Task ValidateApplicationAsync(Uri applicationName, TimeSpan maximumStabilizationTimeout, TimeSpan operationTimeout, CancellationToken token);
        //Task ValidateServiceAsync(Uri serviceName, TimeSpan maximumStabilizationTimeout);
        //Task ValidateServiceAsync(Uri serviceName, TimeSpan maximumStabilizationTimeout, CancellationToken token);
        //Task ValidateServiceAsync(Uri serviceName, TimeSpan maximumStabilizationTimeout, TimeSpan operationTimeout, CancellationToken token);
        //Task<ChaosDescription> GetChaosAsync(TimeSpan operationTimeout, CancellationToken cancellationToken);
        //Task StartChaosAsync(ChaosParameters chaosParameters, TimeSpan operationTimeout, CancellationToken cancellationToken);
        //Task StartChaosAsync(ChaosParameters chaosParameters);
        //Task StopChaosAsync(TimeSpan operationTimeout, CancellationToken cancellationToken);
        //Task StopChaosAsync();
        //Task<ChaosEventsSegment> GetChaosEventsAsync(ChaosEventsSegmentFilter filter, long maxResults, TimeSpan operationTimeout, CancellationToken cancellationToken);
        //Task<ChaosEventsSegment> GetChaosEventsAsync(string continuationToken, long maxResults, TimeSpan operationTimeout, CancellationToken cancellationToken);
        //Task<ChaosScheduleDescription> GetChaosScheduleAsync(TimeSpan operationTimeout, CancellationToken cancellationToken);
        //Task SetChaosScheduleAsync(ChaosScheduleDescription schedule, TimeSpan operationTimeout, CancellationToken cancellationToken);
        //Task<ChaosReport> GetChaosReportAsync(ChaosReportFilter filter);
        //Task<ChaosReport> GetChaosReportAsync(ChaosReportFilter filter, TimeSpan operationTimeout, CancellationToken cancellationToken);
        //Task<ChaosReport> GetChaosReportAsync(string continuationToken);
        //Task<ChaosReport> GetChaosReportAsync(string continuationToken, TimeSpan operationTimeout, CancellationToken cancellationToken);
    }
}