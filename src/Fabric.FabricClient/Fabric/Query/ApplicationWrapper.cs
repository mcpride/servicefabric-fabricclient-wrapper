// MIT License
// Copyright (c) 2021 Marco Stolze

using System;
using System.Fabric.Description;
using System.Fabric.Health;
using System.Fabric.Query;

namespace MS.Extensions.Fabric.Query
{
    internal class ApplicationWrapper : IApplication
    {
        internal readonly Application Application;
        public Uri ApplicationName => Application.ApplicationName;
        public string ApplicationTypeName => Application.ApplicationTypeName;
        public string ApplicationTypeVersion => Application.ApplicationTypeVersion;
        public ApplicationStatus ApplicationStatus => Application.ApplicationStatus;
        public HealthState HealthState => Application.HealthState;
        public ApplicationParameterList ApplicationParameters => Application.ApplicationParameters;
        public ApplicationDefinitionKind ApplicationDefinitionKind => Application.ApplicationDefinitionKind;
        [Obsolete("Use ApplicationUpgradeProgress.")]
        public string UpgradeTypeVersion => Application.UpgradeTypeVersion;
        [Obsolete("Use ApplicationUpgradeProgress.")]
        public ApplicationParameterList UpgradeParameters => Application.UpgradeParameters;
        public ManagedApplicationIdentityDescription ManagedApplicationIdentity
        {
            get => Application.ManagedApplicationIdentity;
            set => Application.ManagedApplicationIdentity = value;
        }

        public ApplicationWrapper(Application application)
        {
            Application = application ?? throw new ArgumentNullException(nameof(application));
        }

        public override bool Equals(object obj)
        {
            if (obj is ApplicationWrapper wrapper)
            {
                return Application.Equals(wrapper.Application);
            }
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return Application.GetHashCode();
        }

        public override string ToString()
        {
            return Application.ToString();
        }
    }
}