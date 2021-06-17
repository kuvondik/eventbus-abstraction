using System;

namespace EventBus.Abstractions
{
    public partial class InMemoryEventBusSubscriptionsManager : IEventBusSubscriptionsManager
    {
        public class SubscriptionInfo
        {
            #region Public Properties

            public bool IsDynamic { get; }
            public Type HandlerType { get; }
            #endregion

            #region Private Constructor

            private SubscriptionInfo(bool isDynamic, Type handlerType)
            {
                IsDynamic = isDynamic;
                HandlerType = handlerType;
            }
            #endregion

            #region Static Methods

            public static SubscriptionInfo Dynamic(Type handlerType)
            {
                return new SubscriptionInfo(true, handlerType);
            }
            public static SubscriptionInfo Typed(Type handlerType)
            {
                return new SubscriptionInfo(false, handlerType);
            }
            #endregion
        }
    }
}
