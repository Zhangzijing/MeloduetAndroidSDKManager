
/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.android.com/sdk/android/repository/11")]
[System.Xml.Serialization.XmlRootAttribute("sdk-repository", Namespace = "http://schemas.android.com/sdk/android/repository/11", IsNullable = false)]
public partial class sdkrepository
{

    private sdkrepositoryLicense[] licenseField;

    private sdkrepositoryNdk ndkField;

    private sdkrepositoryPlatform[] platformField;

    private sdkrepositorySource[] sourceField;

    private sdkrepositoryBuildtool[] buildtoolField;

    private sdkrepositoryPlatformtool platformtoolField;

    private sdkrepositoryTool[] toolField;

    private sdkrepositoryDoc docField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("license")]
    public sdkrepositoryLicense[] license
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
    public sdkrepositoryNdk ndk
    {
        get
        {
            return this.ndkField;
        }
        set
        {
            this.ndkField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("platform")]
    public sdkrepositoryPlatform[] platform
    {
        get
        {
            return this.platformField;
        }
        set
        {
            this.platformField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("source")]
    public sdkrepositorySource[] source
    {
        get
        {
            return this.sourceField;
        }
        set
        {
            this.sourceField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("build-tool")]
    public sdkrepositoryBuildtool[] buildtool
    {
        get
        {
            return this.buildtoolField;
        }
        set
        {
            this.buildtoolField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("platform-tool")]
    public sdkrepositoryPlatformtool platformtool
    {
        get
        {
            return this.platformtoolField;
        }
        set
        {
            this.platformtoolField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("tool")]
    public sdkrepositoryTool[] tool
    {
        get
        {
            return this.toolField;
        }
        set
        {
            this.toolField = value;
        }
    }

    /// <remarks/>
    public sdkrepositoryDoc doc
    {
        get
        {
            return this.docField;
        }
        set
        {
            this.docField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.android.com/sdk/android/repository/11")]
public partial class sdkrepositoryLicense
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
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.android.com/sdk/android/repository/11")]
public partial class sdkrepositoryNdk
{

    private string descriptionField;

    private byte revisionField;

    private sdkrepositoryNdkArchive[] archivesField;

    private sdkrepositoryNdkUseslicense useslicenseField;

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
    [System.Xml.Serialization.XmlArrayItemAttribute("archive", IsNullable = false)]
    public sdkrepositoryNdkArchive[] archives
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
    public sdkrepositoryNdkUseslicense useslicense
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
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.android.com/sdk/android/repository/11")]
public partial class sdkrepositoryNdkArchive
{

    private uint sizeField;

    private sdkrepositoryNdkArchiveChecksum checksumField;

    private string urlField;

    private string hostosField;

    private byte hostbitsField;

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
    public sdkrepositoryNdkArchiveChecksum checksum
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

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("host-bits")]
    public byte hostbits
    {
        get
        {
            return this.hostbitsField;
        }
        set
        {
            this.hostbitsField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.android.com/sdk/android/repository/11")]
public partial class sdkrepositoryNdkArchiveChecksum
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
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.android.com/sdk/android/repository/11")]
public partial class sdkrepositoryNdkUseslicense
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
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.android.com/sdk/android/repository/11")]
public partial class sdkrepositoryPlatform
{

    private string versionField;

    private byte apilevelField;

    private string descriptionField;

    private object obsoleteField;

    private byte revisionField;

    private sdkrepositoryPlatformArchive[] archivesField;

    private sdkrepositoryPlatformUseslicense useslicenseField;

    private sdkrepositoryPlatformMintoolsrev mintoolsrevField;

    private string descurlField;

    private sdkrepositoryPlatformLayoutlib layoutlibField;

    /// <remarks/>
    public string version
    {
        get
        {
            return this.versionField;
        }
        set
        {
            this.versionField = value;
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
    [System.Xml.Serialization.XmlArrayItemAttribute("archive", IsNullable = false)]
    public sdkrepositoryPlatformArchive[] archives
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
    public sdkrepositoryPlatformUseslicense useslicense
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
    [System.Xml.Serialization.XmlElementAttribute("min-tools-rev")]
    public sdkrepositoryPlatformMintoolsrev mintoolsrev
    {
        get
        {
            return this.mintoolsrevField;
        }
        set
        {
            this.mintoolsrevField = value;
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
    public sdkrepositoryPlatformLayoutlib layoutlib
    {
        get
        {
            return this.layoutlibField;
        }
        set
        {
            this.layoutlibField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.android.com/sdk/android/repository/11")]
public partial class sdkrepositoryPlatformArchive
{

    private uint sizeField;

    private sdkrepositoryPlatformArchiveChecksum checksumField;

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
    public sdkrepositoryPlatformArchiveChecksum checksum
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
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.android.com/sdk/android/repository/11")]
public partial class sdkrepositoryPlatformArchiveChecksum
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
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.android.com/sdk/android/repository/11")]
public partial class sdkrepositoryPlatformUseslicense
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
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.android.com/sdk/android/repository/11")]
public partial class sdkrepositoryPlatformMintoolsrev
{

    private byte majorField;

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
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.android.com/sdk/android/repository/11")]
public partial class sdkrepositoryPlatformLayoutlib
{

    private byte apiField;

    private byte revisionField;

    private bool revisionFieldSpecified;

    /// <remarks/>
    public byte api
    {
        get
        {
            return this.apiField;
        }
        set
        {
            this.apiField = value;
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
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool revisionSpecified
    {
        get
        {
            return this.revisionFieldSpecified;
        }
        set
        {
            this.revisionFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.android.com/sdk/android/repository/11")]
public partial class sdkrepositorySource
{

    private byte apilevelField;

    private object obsoleteField;

    private byte revisionField;

    private sdkrepositorySourceArchives archivesField;

    private sdkrepositorySourceUseslicense useslicenseField;

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
    public sdkrepositorySourceArchives archives
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
    public sdkrepositorySourceUseslicense useslicense
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
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.android.com/sdk/android/repository/11")]
public partial class sdkrepositorySourceArchives
{

    private sdkrepositorySourceArchivesArchive archiveField;

    /// <remarks/>
    public sdkrepositorySourceArchivesArchive archive
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
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.android.com/sdk/android/repository/11")]
public partial class sdkrepositorySourceArchivesArchive
{

    private uint sizeField;

    private sdkrepositorySourceArchivesArchiveChecksum checksumField;

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
    public sdkrepositorySourceArchivesArchiveChecksum checksum
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
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.android.com/sdk/android/repository/11")]
public partial class sdkrepositorySourceArchivesArchiveChecksum
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
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.android.com/sdk/android/repository/11")]
public partial class sdkrepositorySourceUseslicense
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
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.android.com/sdk/android/repository/11")]
public partial class sdkrepositoryBuildtool
{

    private object obsoleteField;

    private sdkrepositoryBuildtoolRevision revisionField;

    private sdkrepositoryBuildtoolArchive[] archivesField;

    private sdkrepositoryBuildtoolUseslicense useslicenseField;

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
    public sdkrepositoryBuildtoolRevision revision
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
    public sdkrepositoryBuildtoolArchive[] archives
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
    public sdkrepositoryBuildtoolUseslicense useslicense
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
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.android.com/sdk/android/repository/11")]
public partial class sdkrepositoryBuildtoolRevision
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
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.android.com/sdk/android/repository/11")]
public partial class sdkrepositoryBuildtoolArchive
{

    private uint sizeField;

    private sdkrepositoryBuildtoolArchiveChecksum checksumField;

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
    public sdkrepositoryBuildtoolArchiveChecksum checksum
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
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.android.com/sdk/android/repository/11")]
public partial class sdkrepositoryBuildtoolArchiveChecksum
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
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.android.com/sdk/android/repository/11")]
public partial class sdkrepositoryBuildtoolUseslicense
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
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.android.com/sdk/android/repository/11")]
public partial class sdkrepositoryPlatformtool
{

    private sdkrepositoryPlatformtoolRevision revisionField;

    private sdkrepositoryPlatformtoolArchive[] archivesField;

    private sdkrepositoryPlatformtoolUseslicense useslicenseField;

    /// <remarks/>
    public sdkrepositoryPlatformtoolRevision revision
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
    public sdkrepositoryPlatformtoolArchive[] archives
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
    public sdkrepositoryPlatformtoolUseslicense useslicense
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
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.android.com/sdk/android/repository/11")]
public partial class sdkrepositoryPlatformtoolRevision
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
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.android.com/sdk/android/repository/11")]
public partial class sdkrepositoryPlatformtoolArchive
{

    private uint sizeField;

    private sdkrepositoryPlatformtoolArchiveChecksum checksumField;

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
    public sdkrepositoryPlatformtoolArchiveChecksum checksum
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
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.android.com/sdk/android/repository/11")]
public partial class sdkrepositoryPlatformtoolArchiveChecksum
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
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.android.com/sdk/android/repository/11")]
public partial class sdkrepositoryPlatformtoolUseslicense
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
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.android.com/sdk/android/repository/11")]
public partial class sdkrepositoryTool
{

    private sdkrepositoryToolRevision revisionField;

    private sdkrepositoryToolArchive[] archivesField;

    private sdkrepositoryToolUseslicense useslicenseField;

    private sdkrepositoryToolMinplatformtoolsrev minplatformtoolsrevField;

    /// <remarks/>
    public sdkrepositoryToolRevision revision
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
    public sdkrepositoryToolArchive[] archives
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
    public sdkrepositoryToolUseslicense useslicense
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
    [System.Xml.Serialization.XmlElementAttribute("min-platform-tools-rev")]
    public sdkrepositoryToolMinplatformtoolsrev minplatformtoolsrev
    {
        get
        {
            return this.minplatformtoolsrevField;
        }
        set
        {
            this.minplatformtoolsrevField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.android.com/sdk/android/repository/11")]
public partial class sdkrepositoryToolRevision
{

    private byte majorField;

    private byte minorField;

    private byte microField;

    private byte previewField;

    private bool previewFieldSpecified;

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

    /// <remarks/>
    public byte preview
    {
        get
        {
            return this.previewField;
        }
        set
        {
            this.previewField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool previewSpecified
    {
        get
        {
            return this.previewFieldSpecified;
        }
        set
        {
            this.previewFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.android.com/sdk/android/repository/11")]
public partial class sdkrepositoryToolArchive
{

    private uint sizeField;

    private sdkrepositoryToolArchiveChecksum checksumField;

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
    public sdkrepositoryToolArchiveChecksum checksum
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
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.android.com/sdk/android/repository/11")]
public partial class sdkrepositoryToolArchiveChecksum
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
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.android.com/sdk/android/repository/11")]
public partial class sdkrepositoryToolUseslicense
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
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.android.com/sdk/android/repository/11")]
public partial class sdkrepositoryToolMinplatformtoolsrev
{

    private byte majorField;

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
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.android.com/sdk/android/repository/11")]
public partial class sdkrepositoryDoc
{

    private byte apilevelField;

    private byte revisionField;

    private sdkrepositoryDocArchives archivesField;

    private sdkrepositoryDocUseslicense useslicenseField;

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
    public sdkrepositoryDocArchives archives
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
    public sdkrepositoryDocUseslicense useslicense
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
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.android.com/sdk/android/repository/11")]
public partial class sdkrepositoryDocArchives
{

    private sdkrepositoryDocArchivesArchive archiveField;

    /// <remarks/>
    public sdkrepositoryDocArchivesArchive archive
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
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.android.com/sdk/android/repository/11")]
public partial class sdkrepositoryDocArchivesArchive
{

    private uint sizeField;

    private sdkrepositoryDocArchivesArchiveChecksum checksumField;

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
    public sdkrepositoryDocArchivesArchiveChecksum checksum
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
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.android.com/sdk/android/repository/11")]
public partial class sdkrepositoryDocArchivesArchiveChecksum
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
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.android.com/sdk/android/repository/11")]
public partial class sdkrepositoryDocUseslicense
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

