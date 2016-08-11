namespace sdksysimg.androidtv
{

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.android.com/sdk/android/sys-img/3")]
    [System.Xml.Serialization.XmlRootAttribute("sdk-sys-img", Namespace = "http://schemas.android.com/sdk/android/sys-img/3", IsNullable = false)]
    public partial class sdksysimg
    {

        private sdksysimgLicense[] licenseField;

        private sdksysimgSystemimage[] systemimageField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("license")]
        public sdksysimgLicense[] license
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
        [System.Xml.Serialization.XmlElementAttribute("system-image")]
        public sdksysimgSystemimage[] systemimage
        {
            get
            {
                return this.systemimageField;
            }
            set
            {
                this.systemimageField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.android.com/sdk/android/sys-img/3")]
    public partial class sdksysimgLicense
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.android.com/sdk/android/sys-img/3")]
    public partial class sdksysimgSystemimage
    {

        private byte apilevelField;

        private string descriptionField;

        private byte revisionField;

        private sdksysimgSystemimageArchives archivesField;

        private sdksysimgSystemimageUseslicense useslicenseField;

        private string abiField;

        private string tagidField;

        private string tagdisplayField;

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
        public sdksysimgSystemimageArchives archives
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
        public sdksysimgSystemimageUseslicense useslicense
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
        public string abi
        {
            get
            {
                return this.abiField;
            }
            set
            {
                this.abiField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("tag-id")]
        public string tagid
        {
            get
            {
                return this.tagidField;
            }
            set
            {
                this.tagidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("tag-display")]
        public string tagdisplay
        {
            get
            {
                return this.tagdisplayField;
            }
            set
            {
                this.tagdisplayField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.android.com/sdk/android/sys-img/3")]
    public partial class sdksysimgSystemimageArchives
    {

        private sdksysimgSystemimageArchivesArchive archiveField;

        /// <remarks/>
        public sdksysimgSystemimageArchivesArchive archive
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.android.com/sdk/android/sys-img/3")]
    public partial class sdksysimgSystemimageArchivesArchive
    {

        private uint sizeField;

        private sdksysimgSystemimageArchivesArchiveChecksum checksumField;

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
        public sdksysimgSystemimageArchivesArchiveChecksum checksum
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.android.com/sdk/android/sys-img/3")]
    public partial class sdksysimgSystemimageArchivesArchiveChecksum
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.android.com/sdk/android/sys-img/3")]
    public partial class sdksysimgSystemimageUseslicense
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


}