// MIT License
// Copyright (c) 2021 Marco Stolze

namespace MS.Extensions.Fabric
{
    public interface IFaultManagementClient
    {
        //Task<RestartNodeResult> RestartNodeAsync(string nodeName, BigInteger nodeInstance, CompletionMode completionMode, CancellationToken token);
        //Task<RestartNodeResult> RestartNodeAsync(string nodeName, BigInteger nodeInstance, CompletionMode completionMode);
        //Task<RestartNodeResult> RestartNodeAsync(string nodeName, BigInteger nodeInstance, TimeSpan operationTimeout, CancellationToken token);
        //Task<RestartNodeResult> RestartNodeAsync(string nodeName, BigInteger nodeInstance, bool createFabricDump, CompletionMode completionMode, TimeSpan operationTimeout, CancellationToken token);
        //Task<RestartNodeResult> RestartNodeAsync(ReplicaSelector replicaSelector, CompletionMode completionMode, CancellationToken token);
        //Task<RestartNodeResult> RestartNodeAsync(ReplicaSelector replicaSelector, CompletionMode completionMode);
        //Task<RestartNodeResult> RestartNodeAsync(ReplicaSelector replicaSelector, CompletionMode completionMode, TimeSpan operationTimeout, CancellationToken token);
        //Task<RestartNodeResult> RestartNodeAsync(ReplicaSelector replicaSelector, bool createFabricDump, CompletionMode completionMode, TimeSpan operationTimeout, CancellationToken token);
        //[Obsolete("This api is deprecated, use StartNodeTransitionAsync instead.")]
        //Task<StartNodeResult> StartNodeAsync(string nodeName, BigInteger nodeInstance, CompletionMode completionMode);
        //[Obsolete("This api is deprecated, use StartNodeTransitionAsync instead.")]
        //Task<StartNodeResult> StartNodeAsync(string nodeName, BigInteger nodeInstance, CompletionMode completionMode, CancellationToken token);
        //[Obsolete("This api is deprecated, use StartNodeTransitionAsync instead.")]
        //Task<StartNodeResult> StartNodeAsync(string nodeName, BigInteger nodeInstance, string ipAddressOrFQDN, int clusterConnectionPort, CompletionMode completionMode);
        //[Obsolete("This api is deprecated, use StartNodeTransitionAsync instead.")]
        //Task<StartNodeResult> StartNodeAsync(string nodeName, BigInteger nodeInstance, string ipAddressOrFQDN, int clusterConnectionPort, CompletionMode completionMode, CancellationToken token);
        //[Obsolete("This api is deprecated, use StartNodeTransition instead.")]
        //Task<StartNodeResult> StartNodeAsync(string nodeName, BigInteger nodeInstance, string ipAddressOrFQDN, int clusterConnectionPort, CompletionMode completionMode, TimeSpan operationTimeout, CancellationToken token);
        //[Obsolete("This api is deprecated, use StartNodeTransition instead.")]
        //Task<StopNodeResult> StopNodeAsync(string nodeName, BigInteger nodeInstance, CompletionMode completionMode);
        //[Obsolete("This api is deprecated, use StartNodeTransition instead.")]
        //Task<StopNodeResult> StopNodeAsync(string nodeName, BigInteger nodeInstance, CompletionMode completionMode, CancellationToken token);
        //[Obsolete("This api is deprecated, use StartNodeTransition instead.")]
        //Task<StopNodeResult> StopNodeAsync(string nodeName, BigInteger nodeInstance, CompletionMode completionMode, TimeSpan operationTimeout, CancellationToken token);
        //Task<RestartDeployedCodePackageResult> RestartDeployedCodePackageAsync(Uri applicationName, ReplicaSelector replicaSelector, CompletionMode completionMode, CancellationToken token);
        //Task<RestartDeployedCodePackageResult> RestartDeployedCodePackageAsync(Uri applicationName, ReplicaSelector replicaSelector, CompletionMode completionMode);
        //Task<RestartDeployedCodePackageResult> RestartDeployedCodePackageAsync(Uri applicationName, ReplicaSelector replicaSelector, CompletionMode completionMode, TimeSpan operationTimeout, CancellationToken token);
        //Task<RestartDeployedCodePackageResult> RestartDeployedCodePackageAsync(string nodeName, Uri applicationName, string serviceManifestName, string codePackageName, long codePackageInstanceId, CompletionMode completionMode, CancellationToken token);
        //Task<RestartDeployedCodePackageResult> RestartDeployedCodePackageAsync(string nodeName, Uri applicationName, string serviceManifestName, string servicePackageActivationId, string codePackageName, long codePackageInstanceId, CompletionMode completionMode, CancellationToken token);
        //Task<RestartDeployedCodePackageResult> RestartDeployedCodePackageAsync(string nodeName, Uri applicationName, string serviceManifestName, string codePackageName, long codePackageInstanceId, CompletionMode completionMode);
        //Task<RestartDeployedCodePackageResult> RestartDeployedCodePackageAsync(string nodeName, Uri applicationName, string serviceManifestName, string servicePackageActivationId, string codePackageName, long codePackageInstanceId, CompletionMode completionMode);
        //Task<RestartDeployedCodePackageResult> RestartDeployedCodePackageAsync(string nodeName, Uri applicationName, string serviceManifestName, string codePackageName, long codePackageInstanceId, CompletionMode completionMode, TimeSpan operationTimeout, CancellationToken token);
        //Task<RestartDeployedCodePackageResult> RestartDeployedCodePackageAsync(string nodeName, Uri applicationName, string serviceManifestName, string servicePackageActivationId, string codePackageName, long codePackageInstanceId, CompletionMode completionMode, TimeSpan operationTimeout, CancellationToken token);
        //Task<RemoveReplicaResult> RemoveReplicaAsync(ReplicaSelector replicaSelector, CompletionMode completionMode, bool forceRemove, CancellationToken token);
        //Task<RemoveReplicaResult> RemoveReplicaAsync(ReplicaSelector replicaSelector, CompletionMode completionMode, bool forceRemove);
        //Task<RemoveReplicaResult> RemoveReplicaAsync(ReplicaSelector replicaSelector, CompletionMode completionMode, bool forceRemove, TimeSpan operationTimeout, CancellationToken token);
        //Task<RemoveReplicaResult> RemoveReplicaAsync(string nodeName, Guid partitionId, long replicaId, CompletionMode completionMode, bool forceRemove, CancellationToken token);
        //Task<RemoveReplicaResult> RemoveReplicaAsync(string nodeName, Guid partitionId, long replicaId, CompletionMode completionMode, bool forceRemove);
        //Task<RemoveReplicaResult> RemoveReplicaAsync(string nodeName, Guid partitionId, long replicaId, CompletionMode completionMode, bool forceRemove, double operationTimeoutSec, CancellationToken token);
        //Task<RestartReplicaResult> RestartReplicaAsync(ReplicaSelector replicaSelector, CompletionMode completionMode, CancellationToken token);
        //Task<RestartReplicaResult> RestartReplicaAsync(ReplicaSelector replicaSelector, CompletionMode completionMode);
        //Task<RestartReplicaResult> RestartReplicaAsync(ReplicaSelector replicaSelector, CompletionMode completionMode, TimeSpan operationTimeout, CancellationToken token);
        //Task<RestartReplicaResult> RestartReplicaAsync(string nodeName, Guid partitionId, long replicaId, CompletionMode completionMode, CancellationToken token);
        //Task<RestartReplicaResult> RestartReplicaAsync(string nodeName, Guid partitionId, long replicaId, CompletionMode completionMode);
        //Task<RestartReplicaResult> RestartReplicaAsync(string nodeName, Guid partitionId, long replicaId, CompletionMode completionMode, double operationTimeoutSec, CancellationToken token);
        //Task<MovePrimaryResult> MovePrimaryAsync(PartitionSelector partitionSelector, bool ignoreConstraints);
        //Task<MovePrimaryResult> MovePrimaryAsync(PartitionSelector partitionSelector);
        //Task<MovePrimaryResult> MovePrimaryAsync(PartitionSelector partitionSelector, bool ignoreConstraints, CancellationToken token);
        //Task<MovePrimaryResult> MovePrimaryAsync(PartitionSelector partitionSelector, CancellationToken token);
        //Task<MovePrimaryResult> MovePrimaryAsync(PartitionSelector partitionSelector, bool ignoreConstraints, TimeSpan operationTimeout, CancellationToken token);
        //Task<MovePrimaryResult> MovePrimaryAsync(PartitionSelector partitionSelector, TimeSpan operationTimeout, CancellationToken token);
        //Task<MovePrimaryResult> MovePrimaryAsync(string nodeName, PartitionSelector partitionSelector, bool ignoreConstraints);
        //Task<MovePrimaryResult> MovePrimaryAsync(string nodeName, PartitionSelector partitionSelector);
        //Task<MovePrimaryResult> MovePrimaryAsync(string nodeName, PartitionSelector partitionSelector, bool ignoreConstraints, CancellationToken token);
        //Task<MovePrimaryResult> MovePrimaryAsync(string nodeName, PartitionSelector partitionSelector, CancellationToken token);
        //Task<MovePrimaryResult> MovePrimaryAsync(string nodeName, PartitionSelector partitionSelector, bool ignoreConstraints, TimeSpan operationTimeout, CancellationToken token);
        //Task<MovePrimaryResult> MovePrimaryAsync(string nodeName, PartitionSelector partitionSelector, TimeSpan operationTimeout, CancellationToken token);
        //Task<MoveSecondaryResult> MoveSecondaryAsync(PartitionSelector partitionSelector, bool ignoreConstraints);
        //Task<MoveSecondaryResult> MoveSecondaryAsync(PartitionSelector partitionSelector);
        //Task<MoveSecondaryResult> MoveSecondaryAsync(PartitionSelector partitionSelector, bool ignoreConstraints, CancellationToken token);
        //Task<MoveSecondaryResult> MoveSecondaryAsync(PartitionSelector partitionSelector, CancellationToken token);
        //Task<MoveSecondaryResult> MoveSecondaryAsync(string currentNodeName, PartitionSelector partitionSelector, bool ignoreConstraints);
        //Task<MoveSecondaryResult> MoveSecondaryAsync(string currentNodeName, PartitionSelector partitionSelector);
        //Task<MoveSecondaryResult> MoveSecondaryAsync(string currentNodeName, PartitionSelector partitionSelector, bool ignoreConstraints, CancellationToken token);
        //Task<MoveSecondaryResult> MoveSecondaryAsync(string currentNodeName, PartitionSelector partitionSelector, CancellationToken token);
        //Task<MoveSecondaryResult> MoveSecondaryAsync(string currentNodeName, string newNodeName, PartitionSelector partitionSelector, bool ignoreConstraints);
        //Task<MoveSecondaryResult> MoveSecondaryAsync(string currentNodeName, string newNodeName, PartitionSelector partitionSelector);
        //Task<MoveSecondaryResult> MoveSecondaryAsync(string currentNodeName, string newNodeName, PartitionSelector partitionSelector, bool ignoreConstraints, CancellationToken token);
        //Task<MoveSecondaryResult> MoveSecondaryAsync(string currentNodeName, string newNodeName, PartitionSelector partitionSelector, CancellationToken token);
        //Task<MoveSecondaryResult> MoveSecondaryAsync(string currentNodeName, PartitionSelector partitionSelector, bool ignoreConstraints, TimeSpan operationTimeout, CancellationToken token);
        //Task<MoveSecondaryResult> MoveSecondaryAsync(string currentNodeName, PartitionSelector partitionSelector, TimeSpan operationTimeout, CancellationToken token);
        //Task<MoveSecondaryResult> MoveSecondaryAsync(PartitionSelector partitionSelector, bool ignoreConstraints, TimeSpan operationTimeout, CancellationToken token);
        //Task<MoveSecondaryResult> MoveSecondaryAsync(PartitionSelector partitionSelector, TimeSpan operationTimeout, CancellationToken token);
        //Task<MoveSecondaryResult> MoveSecondaryAsync(string currentNodeName, string newNodeName, PartitionSelector partitionSelector, bool ignoreConstraints, TimeSpan operationTimeout, CancellationToken token);
        //Task<MoveSecondaryResult> MoveSecondaryAsync(string currentNodeName, string newNodeName, PartitionSelector partitionSelector, TimeSpan operationTimeout, CancellationToken token);
    }
}