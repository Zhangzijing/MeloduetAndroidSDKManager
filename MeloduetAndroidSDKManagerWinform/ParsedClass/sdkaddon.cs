
/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.android.com/sdk/android/addon/7")]
[System.Xml.Serialization.XmlRootAttribute("sdk-addon", Namespace = "http://schemas.android.com/sdk/android/addon/7", IsNullable = false)]
public partial class sdkaddon
{

    private sdkaddonLicense[] licenseField;

    private sdkaddonAddon[] addonField;

    private sdkaddonExtra[] extraField;

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
    public sdkaddonAddon[] addon
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

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("extra")]
    public sdkaddonExtra[] extra
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
public partial class sdkaddonAddon
{

    private object obsoleteField;

    private byte revisionField;

    private sdkaddonAddonArchives archivesField;

    private sdkaddonAddonUseslicense useslicenseField;

    private string vendoridField;

    private string vendordisplayField;

    private string nameidField;

    private string namedisplayField;

    private byte apilevelField;

    private string descriptionField;

    private string descurlField;

    private sdkaddonAddonLib[] libsField;

    /// <remarks/>
    public object obsolete
    {
        get
        {
            return this.obsoleteField;
        }
        set
        {
            this.obsoleteField = value;
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
    [System.Xml.Serialization.XmlArrayItemAttribute("lib", IsNullable = false)]
    public sdkaddonAddonLib[] libs
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
public partial class sdkaddonAddonLib
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

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.android.com/sdk/android/addon/7")]
public partial class sdkaddonExtra
{

    private object obsoleteField;

    private sdkaddonExtraRevision revisionField;

    private sdkaddonExtraArchive[] archivesField;

    private sdkaddonExtraUseslicense useslicenseField;

    private string vendoridField;

    private string vendordisplayField;

    private string descriptionField;

    private string descurlField;

    private string namedisplayField;

    private string pathField;

    private string oldpathsField;

    /// <remarks/>
    public object obsolete
    {
        get
        {
            return this.obsoleteField;
        }
        set
        {
            this.obsoleteField = value;
        }
    }

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

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("old-paths")]
    public string oldpaths
    {
        get
        {
            return this.oldpathsField;
        }
        set
        {
            this.oldpathsField = value;
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

    private bool minorFieldSpecified;

    private byte microField;

    private bool microFieldSpecified;

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
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool minorSpecified
    {
        get
        {
            return this.minorFieldSpecified;
        }
        set
        {
            this.minorFieldSpecified = value;
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

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool microSpecified
    {
        get
        {
            return this.microFieldSpecified;
        }
        set
        {
            this.microFieldSpecified = value;
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

