
    using System;
    using System.Web.UI;
    using System.Web.UI.Adapters;

    /// <summary>
    /// Summary description for PageStateAdapter
    /// </summary>
    public class PageStateAdapter : PageAdapter
    {

        public enum StateStorageTypes { Default, Session, InPage }


        /// <summary>
        /// Returns an object that is used by the Web page to maintain the control and view states.
        /// </summary>
        /// <returns>
        /// An object derived from <see cref="T:System.Web.UI.PageStatePersister"/> that supports creating and extracting the 
        /// combined control and view states for the <see cref="T:System.Web.UI.Page"/>.
        /// </returns>
        public override PageStatePersister GetStatePersister()
        {
            PageViewStateStorageAttribute psa =
                Attribute.GetCustomAttribute(this.Page.GetType(), typeof(PageViewStateStorageAttribute), true) as PageViewStateStorageAttribute ??
                new PageViewStateStorageAttribute(StateStorageTypes.Default);

            PageStatePersister psp;
            switch (psa.StorageType)
            {
                case StateStorageTypes.Session:
                    psp = new SessionPageStatePersister(this.Page);
                    break;
                case StateStorageTypes.InPage:
                    psp = new HiddenFieldPageStatePersister(this.Page);
                    break;
                //case StateStorageTypes.Default:
                default:
                    psp = new SessionPageStatePersister(this.Page);
                    break;
            }
            return psp;
        }

        /// <summary>
        /// Attribute to be applied to a page object.  When applied, determins how the viewstate storage is treated for that individual page.
        /// </summary>
        [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
        public class PageViewStateStorageAttribute : Attribute
        {
            private readonly StateStorageTypes storageType = StateStorageTypes.Default;

            /// <summary>
            /// Initializes a new instance of the <see cref="PageViewStateStorageAttribute"/> class.
            /// </summary>
            /// <param name="stateStorageType">Type of the state storage.</param>
            public PageViewStateStorageAttribute(StateStorageTypes stateStorageType)
            {
                this.storageType = stateStorageType;
            }

            internal StateStorageTypes StorageType
            {
                get { return this.storageType; }
            }
        }

    }
