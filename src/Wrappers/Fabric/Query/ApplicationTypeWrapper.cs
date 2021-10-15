// MIT License
// Copyright (c) 2021 Marco Stolze

using System;
using System.Fabric.Description;
using System.Fabric.Query;

namespace MS.Extensions.Fabric.Query
{
    /// <inheritdoc />
    internal class ApplicationTypeWrapper : IApplicationType
    {
        internal readonly ApplicationType Item;

        /// <inheritdoc />
        public string ApplicationTypeName => Item.ApplicationTypeName;

        /// <inheritdoc />
        public string ApplicationTypeVersion => Item.ApplicationTypeVersion;

        /// <inheritdoc />
        public ApplicationTypeStatus Status => Item.Status;

        /// <inheritdoc />
        public string StatusDetails => Item.StatusDetails;

        /// <inheritdoc />
        public ApplicationParameterList DefaultParameters => Item.DefaultParameters;

        /// <inheritdoc />
        public ApplicationTypeDefinitionKind ApplicationTypeDefinitionKind => Item.ApplicationTypeDefinitionKind;

        public ApplicationTypeWrapper(ApplicationType item)
        {
            Item = item ?? throw new ArgumentNullException(nameof(item));
        }

        public static bool operator == (ApplicationTypeWrapper value1, ApplicationTypeWrapper value2)
        {
            // ReSharper disable RedundantCast
            if ((object)value1 == (object)value2) return true;
            return (object)value1 != null && (object)value2 != null && value1.Item == value2.Item;
            // ReSharper restore RedundantCast
        }

        public static bool operator != (ApplicationTypeWrapper value1, ApplicationTypeWrapper value2)
        {
            return !(value1 == value2);
        }

        public override bool Equals(object obj)
        {
            if (obj is ApplicationTypeWrapper wrapper)
            {
                return Item.Equals(wrapper.Item);
            }
            // ReSharper disable once BaseObjectEqualsIsObjectEquals
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
