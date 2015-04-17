//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BVNetwork.EPiSendMail.Configuration
{
    
    
    /// <summary>
    /// The NewsletterConfigurationSection Configuration Section.
    /// </summary>
    public partial class NewsletterConfigurationSection : global::System.Configuration.ConfigurationSection
    {
        
        #region Singleton Instance
        /// <summary>
        /// The XML name of the NewsletterConfigurationSection Configuration Section.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        internal const string NewsletterConfigurationSectionSectionName = "epicodeNewsletter";
        
        /// <summary>
        /// The XML path of the NewsletterConfigurationSection Configuration Section.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        internal const string NewsletterConfigurationSectionSectionPath = "epicodeNewsletter";
        
        /// <summary>
        /// Gets the NewsletterConfigurationSection instance.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        public static global::BVNetwork.EPiSendMail.Configuration.NewsletterConfigurationSection Instance
        {
            get
            {
                return ((global::BVNetwork.EPiSendMail.Configuration.NewsletterConfigurationSection)(global::System.Configuration.ConfigurationManager.GetSection(global::BVNetwork.EPiSendMail.Configuration.NewsletterConfigurationSection.NewsletterConfigurationSectionSectionPath)));
            }
        }
        #endregion
        
        #region Xmlns Property
        /// <summary>
        /// The XML name of the <see cref="Xmlns"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        internal const string XmlnsPropertyName = "xmlns";
        
        /// <summary>
        /// Gets the XML namespace of this Configuration Section.
        /// </summary>
        /// <remarks>
        /// This property makes sure that if the configuration file contains the XML namespace,
        /// the parser doesn't throw an exception because it encounters the unknown "xmlns" attribute.
        /// </remarks>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::BVNetwork.EPiSendMail.Configuration.NewsletterConfigurationSection.XmlnsPropertyName, IsRequired=false, IsKey=false, IsDefaultCollection=false)]
        public string Xmlns
        {
            get
            {
                return ((string)(base[global::BVNetwork.EPiSendMail.Configuration.NewsletterConfigurationSection.XmlnsPropertyName]));
            }
        }
        #endregion
        
        #region IsReadOnly override
        /// <summary>
        /// Gets a value indicating whether the element is read-only.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        public override bool IsReadOnly()
        {
            return false;
        }
        #endregion
        
        #region SenderType Property
        /// <summary>
        /// The XML name of the <see cref="SenderType"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        internal const string SenderTypePropertyName = "senderType";
        
        /// <summary>
        /// Gets or sets the SenderType.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        [global::System.ComponentModel.DescriptionAttribute("The SenderType.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::BVNetwork.EPiSendMail.Configuration.NewsletterConfigurationSection.SenderTypePropertyName, IsRequired=false, IsKey=false, IsDefaultCollection=false)]
        public virtual string SenderType
        {
            get
            {
                return ((string)(base[global::BVNetwork.EPiSendMail.Configuration.NewsletterConfigurationSection.SenderTypePropertyName]));
            }
            set
            {
                base[global::BVNetwork.EPiSendMail.Configuration.NewsletterConfigurationSection.SenderTypePropertyName] = value;
            }
        }
        #endregion
        
        #region RecipientListProviders Property
        /// <summary>
        /// The XML name of the <see cref="RecipientListProviders"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        internal const string RecipientListProvidersPropertyName = "recipientListProviders";
        
        /// <summary>
        /// Gets or sets the RecipientListProviders.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        [global::System.ComponentModel.DescriptionAttribute("The RecipientListProviders.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::BVNetwork.EPiSendMail.Configuration.NewsletterConfigurationSection.RecipientListProvidersPropertyName, IsRequired=false, IsKey=false, IsDefaultCollection=false)]
        public virtual global::BVNetwork.EPiSendMail.Configuration.RecipientListProviders RecipientListProviders
        {
            get
            {
                return ((global::BVNetwork.EPiSendMail.Configuration.RecipientListProviders)(base[global::BVNetwork.EPiSendMail.Configuration.NewsletterConfigurationSection.RecipientListProvidersPropertyName]));
            }
            set
            {
                base[global::BVNetwork.EPiSendMail.Configuration.NewsletterConfigurationSection.RecipientListProvidersPropertyName] = value;
            }
        }
        #endregion
    }
}
namespace BVNetwork.EPiSendMail.Configuration
{
    
    
    /// <summary>
    /// A collection of RecipientListProvider instances.
    /// </summary>
    [global::System.Configuration.ConfigurationCollectionAttribute(typeof(global::BVNetwork.EPiSendMail.Configuration.RecipientListProvider), CollectionType=global::System.Configuration.ConfigurationElementCollectionType.AddRemoveClearMap, AddItemName="add", RemoveItemName="remove", ClearItemsName="clear")]
    public partial class RecipientListProviders : global::System.Configuration.ConfigurationElementCollection
    {
        
        #region Constants
        /// <summary>
        /// The XML name of the individual <see cref="global::BVNetwork.EPiSendMail.Configuration.RecipientListProvider"/> instances in this collection.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        internal const string RecipientListProviderPropertyName = "recipientListProvider";
        #endregion
        
        #region Overrides
        /// <summary>
        /// Gets the type of the <see cref="global::System.Configuration.ConfigurationElementCollection"/>.
        /// </summary>
        /// <returns>The <see cref="global::System.Configuration.ConfigurationElementCollectionType"/> of this collection.</returns>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        public override global::System.Configuration.ConfigurationElementCollectionType CollectionType
        {
            get
            {
                return global::System.Configuration.ConfigurationElementCollectionType.AddRemoveClearMap;
            }
        }
        
        /// <summary>
        /// Gets the name used to identify this collection of elements
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        protected override string ElementName
        {
            get
            {
                return global::BVNetwork.EPiSendMail.Configuration.RecipientListProviders.RecipientListProviderPropertyName;
            }
        }
        
        /// <summary>
        /// Indicates whether the specified <see cref="global::System.Configuration.ConfigurationElement"/> exists in the <see cref="global::System.Configuration.ConfigurationElementCollection"/>.
        /// </summary>
        /// <param name="elementName">The name of the element to verify.</param>
        /// <returns>
        /// <see langword="true"/> if the element exists in the collection; otherwise, <see langword="false"/>.
        /// </returns>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        protected override bool IsElementName(string elementName)
        {
            return (elementName == global::BVNetwork.EPiSendMail.Configuration.RecipientListProviders.RecipientListProviderPropertyName);
        }
        
        /// <summary>
        /// Gets the element key for the specified configuration element.
        /// </summary>
        /// <param name="element">The <see cref="global::System.Configuration.ConfigurationElement"/> to return the key for.</param>
        /// <returns>
        /// An <see cref="object"/> that acts as the key for the specified <see cref="global::System.Configuration.ConfigurationElement"/>.
        /// </returns>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        protected override object GetElementKey(global::System.Configuration.ConfigurationElement element)
        {
            return ((global::BVNetwork.EPiSendMail.Configuration.RecipientListProvider)(element)).Name;
        }
        
        /// <summary>
        /// Creates a new <see cref="global::BVNetwork.EPiSendMail.Configuration.RecipientListProvider"/>.
        /// </summary>
        /// <returns>
        /// A new <see cref="global::BVNetwork.EPiSendMail.Configuration.RecipientListProvider"/>.
        /// </returns>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        protected override global::System.Configuration.ConfigurationElement CreateNewElement()
        {
            return new global::BVNetwork.EPiSendMail.Configuration.RecipientListProvider();
        }
        #endregion
        
        #region Indexer
        /// <summary>
        /// Gets the <see cref="global::BVNetwork.EPiSendMail.Configuration.RecipientListProvider"/> at the specified index.
        /// </summary>
        /// <param name="index">The index of the <see cref="global::BVNetwork.EPiSendMail.Configuration.RecipientListProvider"/> to retrieve.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        public global::BVNetwork.EPiSendMail.Configuration.RecipientListProvider this[int index]
        {
            get
            {
                return ((global::BVNetwork.EPiSendMail.Configuration.RecipientListProvider)(base.BaseGet(index)));
            }
        }
        
        /// <summary>
        /// Gets the <see cref="global::BVNetwork.EPiSendMail.Configuration.RecipientListProvider"/> with the specified key.
        /// </summary>
        /// <param name="name">The key of the <see cref="global::BVNetwork.EPiSendMail.Configuration.RecipientListProvider"/> to retrieve.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        public global::BVNetwork.EPiSendMail.Configuration.RecipientListProvider this[object name]
        {
            get
            {
                return ((global::BVNetwork.EPiSendMail.Configuration.RecipientListProvider)(base.BaseGet(name)));
            }
        }
        #endregion
        
        #region Add
        /// <summary>
        /// Adds the specified <see cref="global::BVNetwork.EPiSendMail.Configuration.RecipientListProvider"/> to the <see cref="global::System.Configuration.ConfigurationElementCollection"/>.
        /// </summary>
        /// <param name="recipientListProvider">The <see cref="global::BVNetwork.EPiSendMail.Configuration.RecipientListProvider"/> to add.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        public void Add(global::BVNetwork.EPiSendMail.Configuration.RecipientListProvider recipientListProvider)
        {
            base.BaseAdd(recipientListProvider);
        }
        #endregion
        
        #region Remove
        /// <summary>
        /// Removes the specified <see cref="global::BVNetwork.EPiSendMail.Configuration.RecipientListProvider"/> from the <see cref="global::System.Configuration.ConfigurationElementCollection"/>.
        /// </summary>
        /// <param name="recipientListProvider">The <see cref="global::BVNetwork.EPiSendMail.Configuration.RecipientListProvider"/> to remove.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        public void Remove(global::BVNetwork.EPiSendMail.Configuration.RecipientListProvider recipientListProvider)
        {
            base.BaseRemove(this.GetElementKey(recipientListProvider));
        }
        #endregion
        
        #region GetItem
        /// <summary>
        /// Gets the <see cref="global::BVNetwork.EPiSendMail.Configuration.RecipientListProvider"/> at the specified index.
        /// </summary>
        /// <param name="index">The index of the <see cref="global::BVNetwork.EPiSendMail.Configuration.RecipientListProvider"/> to retrieve.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        public global::BVNetwork.EPiSendMail.Configuration.RecipientListProvider GetItemAt(int index)
        {
            return ((global::BVNetwork.EPiSendMail.Configuration.RecipientListProvider)(base.BaseGet(index)));
        }
        
        /// <summary>
        /// Gets the <see cref="global::BVNetwork.EPiSendMail.Configuration.RecipientListProvider"/> with the specified key.
        /// </summary>
        /// <param name="name">The key of the <see cref="global::BVNetwork.EPiSendMail.Configuration.RecipientListProvider"/> to retrieve.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        public global::BVNetwork.EPiSendMail.Configuration.RecipientListProvider GetItemByKey(string name)
        {
            return ((global::BVNetwork.EPiSendMail.Configuration.RecipientListProvider)(base.BaseGet(((object)(name)))));
        }
        #endregion
        
        #region IsReadOnly override
        /// <summary>
        /// Gets a value indicating whether the element is read-only.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        public override bool IsReadOnly()
        {
            return false;
        }
        #endregion
    }
}
namespace BVNetwork.EPiSendMail.Configuration
{
    
    
    /// <summary>
    /// The RecipientListProvider Configuration Element.
    /// </summary>
    public partial class RecipientListProvider : global::System.Configuration.ConfigurationElement
    {
        
        #region IsReadOnly override
        /// <summary>
        /// Gets a value indicating whether the element is read-only.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        public override bool IsReadOnly()
        {
            return false;
        }
        #endregion
        
        #region Name Property
        /// <summary>
        /// The XML name of the <see cref="Name"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        internal const string NamePropertyName = "name";
        
        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        [global::System.ComponentModel.DescriptionAttribute("The Name.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::BVNetwork.EPiSendMail.Configuration.RecipientListProvider.NamePropertyName, IsRequired=true, IsKey=true, IsDefaultCollection=false)]
        public virtual string Name
        {
            get
            {
                return ((string)(base[global::BVNetwork.EPiSendMail.Configuration.RecipientListProvider.NamePropertyName]));
            }
            set
            {
                base[global::BVNetwork.EPiSendMail.Configuration.RecipientListProvider.NamePropertyName] = value;
            }
        }
        #endregion
        
        #region DisplayName Property
        /// <summary>
        /// The XML name of the <see cref="DisplayName"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        internal const string DisplayNamePropertyName = "displayName";
        
        /// <summary>
        /// Gets or sets the DisplayName.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        [global::System.ComponentModel.DescriptionAttribute("The DisplayName.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::BVNetwork.EPiSendMail.Configuration.RecipientListProvider.DisplayNamePropertyName, IsRequired=true, IsKey=false, IsDefaultCollection=false)]
        public virtual string DisplayName
        {
            get
            {
                return ((string)(base[global::BVNetwork.EPiSendMail.Configuration.RecipientListProvider.DisplayNamePropertyName]));
            }
            set
            {
                base[global::BVNetwork.EPiSendMail.Configuration.RecipientListProvider.DisplayNamePropertyName] = value;
            }
        }
        #endregion
        
        #region Url Property
        /// <summary>
        /// The XML name of the <see cref="Url"/> property.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        internal const string UrlPropertyName = "url";
        
        /// <summary>
        /// Gets or sets the Url.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ConfigurationSectionDesigner.CsdFileGenerator", "2.0.1.7")]
        [global::System.ComponentModel.DescriptionAttribute("The Url.")]
        [global::System.Configuration.ConfigurationPropertyAttribute(global::BVNetwork.EPiSendMail.Configuration.RecipientListProvider.UrlPropertyName, IsRequired=true, IsKey=false, IsDefaultCollection=false)]
        public virtual string Url
        {
            get
            {
                return ((string)(base[global::BVNetwork.EPiSendMail.Configuration.RecipientListProvider.UrlPropertyName]));
            }
            set
            {
                base[global::BVNetwork.EPiSendMail.Configuration.RecipientListProvider.UrlPropertyName] = value;
            }
        }
        #endregion
    }
}
