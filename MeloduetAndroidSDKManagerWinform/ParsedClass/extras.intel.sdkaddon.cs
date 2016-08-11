namespace extras.intel
{

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.android.com/sdk/android/addon/7")]
    [System.Xml.Serialization.XmlRootAttribute("sdk-addon", Namespace = "http://schemas.android.com/sdk/android/addon/7", IsNullable = false)]
    public partial class sdkaddon
    {

        private sdkaddonLicense[] licenseField;

        private sdkaddonExtra extraField;

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
        public sdkaddonExtra extra
        {
            get
            {
                return this.extraField;
            }
            set
            {
                this.extraField = value;
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
    public partial class sdkaddonExtra
    {

        private sdkaddonExtraRevision revisionField;

        private sdkaddonExtraArchive[] archivesField;

        private sdkaddonExtraUseslicense useslicenseField;

        private string vendoridField;

        private string vendordisplayField;

        private string descriptionField;

        private string descurlField;

        private string namedisplayField;

        private string pathField;

        /// <remarks/>
        public sdkaddonExtraRevision revision
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
        [System.Xml.Serialization.XmlArrayItemAttribute("archive", IsNullable = false)]
        public sdkaddonExtraArchive[] archives
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
        public sdkaddonExtraUseslicense useslicense
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
        [System.Xml.Serialization.XmlElementAttribute("desc-url")]
        public string descurl
        {
            get
            {
                return this.descurlField;
            }
            set
            {
                this.descurlField = value;
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
        public string path
        {
            get
            {
                return this.pathField;
            }
            set
            {
                this.pathField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.android.com/sdk/android/addon/7")]
    public partial class sdkaddonExtraRevision
    {

        private byte majorField;

        private byte minorField;

        private byte microField;

        /// <remarks/>
        public byte major
        {
            get
            {
                return this.majorField;
            }
            set
            {
                this.majorField = value;
            }
        }

        /// <remarks/>
        public byte minor
        {
            get
            {
                return this.minorField;
            }
            set
            {
                this.minorField = value;
            }
        }

        /// <remarks/>
        public byte micro
        {
            get
            {
                return this.microField;
            }
            set
            {
                this.microField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.android.com/sdk/android/addon/7")]
    public partial class sdkaddonExtraArchive
    {

        private uint sizeField;

        private sdkaddonExtraArchiveChecksum checksumField;

        private string urlField;

        private string hostosField;

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
        public sdkaddonExtraArchiveChecksum checksum
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

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("host-os")]
        public string hostos
        {
            get
            {
                return this.hostosField;
            }
            set
            {
                this.hostosField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.android.com/sdk/android/addon/7")]
    public partial class sdkaddonExtraArchiveChecksum
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
    public partial class sdkaddonExtraUseslicense
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