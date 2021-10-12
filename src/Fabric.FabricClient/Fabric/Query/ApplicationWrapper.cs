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
        internal readonly Application Item;
        public Uri ApplicationName => Item.ApplicationName;
        public string ApplicationTypeName => Item.ApplicationTypeName;
        public string ApplicationTypeVersion => Item.ApplicationTypeVersion;
        public ApplicationStatus ApplicationStatus => Item.ApplicationStatus;
        public HealthState HealthState => Item.HealthState;
        public ApplicationParameterList ApplicationParameters => Item.ApplicationParameters;
        public ApplicationDefinitionKind ApplicationDefinitionKind => Item.ApplicationDefinitionKind;
        [Obsolete("Use ApplicationUpgradeProgress.")]
        public string UpgradeTypeVersion => Item.UpgradeTypeVersion;
        [Obsolete("Use ApplicationUpgradeProgress.")]
        public ApplicationParameterList UpgradeParameters => Item.UpgradeParameters;
        public ManagedApplicationIdentityDescription ManagedApplicationIdentity
        {
            get => Item.ManagedApplicationIdentity;
            set => Item.ManagedApplicationIdentity = value;
        }

        public ApplicationWrapper(Application item)
        {
            Item = item ?? throw new ArgumentNullException(nameof(item));
        }

        public static bool operator ==(ApplicationWrapper value1, ApplicationWrapper value2)
        {
            if ((object)value1 == (object)value2) return true;
            return (object)value1 != null && (object)value2 != null && value1.Item == value2.Item;
        }

        public static bool operator !=(ApplicationWrapper value1, ApplicationWrapper value2)
        {
            return !(value1 == value2);
        }

        public override bool Equals(object obj)
        {
            if (obj is ApplicationWrapper wrapper)
            {
                return Item.Equals(wrapper.Item);
            }
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return Item.GetHashCode();
        }

        public override string ToString()
        {
            return Item.ToString();
        }
    }
}