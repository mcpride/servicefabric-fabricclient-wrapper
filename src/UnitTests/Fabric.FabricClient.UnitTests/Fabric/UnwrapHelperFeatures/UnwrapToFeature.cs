using System;
using Xunit;
using MS.Extensions.Tools;

namespace MS.Extensions.Fabric.UnwrapHelperFeatures
{
    public interface IWrap
    {
        void Test();
    }

    internal abstract class BaseType
    {
        public void Test()
        {
            //do nothing
        }
    }

    internal class ValidType : BaseType, IWrap
    {
    }

    internal class InvalidType
    {
        public void Test()
        {
            //do nothing
        }
    }

    internal class InvalidType2 : IWrap
    {
        public void Test()
        {
            //do nothing
        }
    }

    public class UnwrapToFeature
    {
        [Fact]
        public void Interfaces_should_be_unwrapped_to_implementation_types()
        {
            IWrap wrapped = new ValidType();
            var unwrapped = wrapped.UnwrapTo<ValidType>();
            Assert.IsType<ValidType>(unwrapped);
        }

        [Fact]
        public void Interfaces_should_be_unwrapped_to_base_types()
        {
            IWrap wrapped = new ValidType();
            var unwrapped = wrapped.UnwrapTo<BaseType>();
            Assert.IsAssignableFrom<BaseType>(unwrapped);
        }

        [Fact]
        public void Unwrapping_invalid_types_should_should_throw_InvalidOperationException()
        {
            IWrap wrapped = new ValidType();
            Assert.Throws<InvalidOperationException>(() => wrapped.UnwrapTo<InvalidType>());
        }

        [Fact]
        public void Unwrapping_invalid_types_2_should_should_throw_InvalidOperationException()
        {
            IWrap wrapped = new ValidType();
            Assert.Throws<InvalidOperationException>(() => wrapped.UnwrapTo<InvalidType2>());
        }

        [Fact]
        public void Null_values_should_be_unwrapped_to_base_types()
        {
            IWrap wrapped = null;
            var unwrapped = wrapped.UnwrapTo<BaseType>();
            Assert.Null(unwrapped);
        }
    }
}
