namespace glass
{
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.android.com/sdk/android/addon/7")]
    [System.Xml.Serialization.XmlRootAttribute("sdk-addon", Namespace = "http://schemas.android.com/sdk/android/addon/7", IsNullable = false)]
    public partial class sdkaddon
    {

        private sdkaddonLicense[] licenseField;

        private sdkaddonAddon addonField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("license")]
        public sdkaddonLicense[] license
        {
            get
            {
                return this.licenseField;
            }
            set
            {
                this.licenseField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("add-on")]
        public sdkaddonAddon addon
        {
            get
            {
                return this.addonField;
            }
            set
            {
                this.addonField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.android.com/sdk/android/addon/7")]
    public partial class sdkaddonLicense
    {

        private string idField;

        private string typeField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.android.com/sdk/android/addon/7")]
    public partial class sdkaddonAddon
    {

        private byte revisionField;

        private sdkaddonAddonArchives archivesField;

        private sdkaddonAddonUseslicense useslicenseField;

        private string vendoridField;

        private string vendordisplayField;

        private string nameidField;

        private string namedisplayField;

        private byte apilevelField;

        private string descriptionField;

        private sdkaddonAddonLibs libsField;

        /// <remarks/>
        public byte revision
        {
            get
            {
                return this.revisionField;
            }
            set
            {
                this.revisionField = value;
            }
        }

        /// <remarks/>
        public sdkaddonAddonArchives archives
        {
            get
            {
                return this.archivesField;
            }
            set
            {
                this.archivesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("uses-license")]
        public sdkaddonAddonUseslicense useslicense
        {
            get
            {
                return this.useslicenseField;
            }
            set
            {
                this.useslicenseField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("vendor-id")]
        public string vendorid
        {
            get
            {
                return this.vendoridField;
            }
            set
            {
                this.vendoridField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("vendor-display")]
        public string vendordisplay
        {
            get
            {
                return this.vendordisplayField;
            }
            set
            {
                this.vendordisplayField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("name-id")]
        public string nameid
        {
            get
            {
                return this.nameidField;
            }
            set
            {
                this.nameidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("name-display")]
        public string namedisplay
        {
            get
            {
                return this.namedisplayField;
            }
            set
            {
                this.namedisplayField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("api-level")]
        public byte apilevel
        {
            get
            {
                return this.apilevelField;
            }
            set
            {
                this.apilevelField = value;
            }
        }

        /// <remarks/>
        public string description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        public sdkaddonAddonLibs libs
        {
            get
            {
                return this.libsField;
            }
            set
            {
                this.libsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.android.com/sdk/android/addon/7")]
    public partial class sdkaddonAddonArchives
    {

        private sdkaddonAddonArchivesArchive archiveField;

        /// <remarks/>
        public sdkaddonAddonArchivesArchive archive
        {
            get
            {
                return this.archiveField;
            }
            set
            {
                this.archiveField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.android.com/sdk/android/addon/7")]
    public partial class sdkaddonAddonArchivesArchive
    {

        private uint sizeField;

        private sdkaddonAddonArchivesArchiveChecksum checksumField;

        private string urlField;

        /// <remarks/>
        public uint size
        {
            get
            {
                return this.sizeField;
            }
            set
            {
                this.sizeField = value;
            }
        }

        /// <remarks/>
        public sdkaddonAddonArchivesArchiveChecksum checksum
        {
            get
            {
                return this.checksumField;
            }
            set
            {
                this.checksumField = value;
            }
        }

        /// <remarks/>
        public string url
        {
            get
            {
                return this.urlField;
            }
            set
            {
                this.urlField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.android.com/sdk/android/addon/7")]
    public partial class sdkaddonAddonArchivesArchiveChecksum
    {

        private string typeField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.android.com/sdk/android/addon/7")]
    public partial class sdkaddonAddonUseslicense
    {

        private string refField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string @ref
        {
            get
            {
                return this.refField;
            }
            set
            {
                this.refField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.android.com/sdk/android/addon/7")]
    public partial class sdkaddonAddonLibs
    {

        private sdkaddonAddonLibsLib libField;

        /// <remarks/>
        public sdkaddonAddonLibsLib lib
        {
            get
            {
                return this.libField;
            }
            set
            {
                this.libField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.android.com/sdk/android/addon/7")]
    public partial class sdkaddonAddonLibsLib
    {

        private string nameField;

        private string descriptionField;

        /// <remarks/>
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public string description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }
    }


}