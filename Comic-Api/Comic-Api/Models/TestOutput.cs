namespace Comic_Api.Models
{
    public class TestOutput
    {
// NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
public partial class volume
{

    private object aliasesField;

    private string api_detail_urlField;

    private byte count_of_issuesField;

    private string date_addedField;

    private string date_last_updatedField;

    private object deckField;

    private string descriptionField;

    private volumeFirst_issue first_issueField;

    private ushort idField;

    private volumeImage imageField;

    private volumeLast_issue last_issueField;

    private string nameField;

    private volumePublisher publisherField;

    private string site_detail_urlField;

    private ushort start_yearField;

    /// <remarks/>
    public object aliases
    {
        get
        {
            return this.aliasesField;
        }
        set
        {
            this.aliasesField = value;
        }
    }

    /// <remarks/>
    public string api_detail_url
    {
        get
        {
            return this.api_detail_urlField;
        }
        set
        {
            this.api_detail_urlField = value;
        }
    }

    /// <remarks/>
    public byte count_of_issues
    {
        get
        {
            return this.count_of_issuesField;
        }
        set
        {
            this.count_of_issuesField = value;
        }
    }

    /// <remarks/>
    public string date_added
    {
        get
        {
            return this.date_addedField;
        }
        set
        {
            this.date_addedField = value;
        }
    }

    /// <remarks/>
    public string date_last_updated
    {
        get
        {
            return this.date_last_updatedField;
        }
        set
        {
            this.date_last_updatedField = value;
        }
    }

    /// <remarks/>
    public object deck
    {
        get
        {
            return this.deckField;
        }
        set
        {
            this.deckField = value;
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
    public volumeFirst_issue first_issue
    {
        get
        {
            return this.first_issueField;
        }
        set
        {
            this.first_issueField = value;
        }
    }

    /// <remarks/>
    public ushort id
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
    public volumeImage image
    {
        get
        {
            return this.imageField;
        }
        set
        {
            this.imageField = value;
        }
    }

    /// <remarks/>
    public volumeLast_issue last_issue
    {
        get
        {
            return this.last_issueField;
        }
        set
        {
            this.last_issueField = value;
        }
    }

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
    public volumePublisher publisher
    {
        get
        {
            return this.publisherField;
        }
        set
        {
            this.publisherField = value;
        }
    }

    /// <remarks/>
    public string site_detail_url
    {
        get
        {
            return this.site_detail_urlField;
        }
        set
        {
            this.site_detail_urlField = value;
        }
    }

    /// <remarks/>
    public ushort start_year
    {
        get
        {
            return this.start_yearField;
        }
        set
        {
            this.start_yearField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class volumeFirst_issue
{

    private string api_detail_urlField;

    private uint idField;

    private string nameField;

    private byte issue_numberField;

    /// <remarks/>
    public string api_detail_url
    {
        get
        {
            return this.api_detail_urlField;
        }
        set
        {
            this.api_detail_urlField = value;
        }
    }

    /// <remarks/>
    public uint id
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
    public byte issue_number
    {
        get
        {
            return this.issue_numberField;
        }
        set
        {
            this.issue_numberField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class volumeImage
{

    private string icon_urlField;

    private string medium_urlField;

    private string screen_urlField;

    private string screen_large_urlField;

    private string small_urlField;

    private string super_urlField;

    private string thumb_urlField;

    private string tiny_urlField;

    private string original_urlField;

    private string image_tagsField;

    /// <remarks/>
    public string icon_url
    {
        get
        {
            return this.icon_urlField;
        }
        set
        {
            this.icon_urlField = value;
        }
    }

    /// <remarks/>
    public string medium_url
    {
        get
        {
            return this.medium_urlField;
        }
        set
        {
            this.medium_urlField = value;
        }
    }

    /// <remarks/>
    public string screen_url
    {
        get
        {
            return this.screen_urlField;
        }
        set
        {
            this.screen_urlField = value;
        }
    }

    /// <remarks/>
    public string screen_large_url
    {
        get
        {
            return this.screen_large_urlField;
        }
        set
        {
            this.screen_large_urlField = value;
        }
    }

    /// <remarks/>
    public string small_url
    {
        get
        {
            return this.small_urlField;
        }
        set
        {
            this.small_urlField = value;
        }
    }

    /// <remarks/>
    public string super_url
    {
        get
        {
            return this.super_urlField;
        }
        set
        {
            this.super_urlField = value;
        }
    }

    /// <remarks/>
    public string thumb_url
    {
        get
        {
            return this.thumb_urlField;
        }
        set
        {
            this.thumb_urlField = value;
        }
    }

    /// <remarks/>
    public string tiny_url
    {
        get
        {
            return this.tiny_urlField;
        }
        set
        {
            this.tiny_urlField = value;
        }
    }

    /// <remarks/>
    public string original_url
    {
        get
        {
            return this.original_urlField;
        }
        set
        {
            this.original_urlField = value;
        }
    }

    /// <remarks/>
    public string image_tags
    {
        get
        {
            return this.image_tagsField;
        }
        set
        {
            this.image_tagsField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class volumeLast_issue
{

    private string api_detail_urlField;

    private uint idField;

    private string nameField;

    private byte issue_numberField;

    /// <remarks/>
    public string api_detail_url
    {
        get
        {
            return this.api_detail_urlField;
        }
        set
        {
            this.api_detail_urlField = value;
        }
    }

    /// <remarks/>
    public uint id
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
    public byte issue_number
    {
        get
        {
            return this.issue_numberField;
        }
        set
        {
            this.issue_numberField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class volumePublisher
{

    private string api_detail_urlField;

    private byte idField;

    private string nameField;

    /// <remarks/>
    public string api_detail_url
    {
        get
        {
            return this.api_detail_urlField;
        }
        set
        {
            this.api_detail_urlField = value;
        }
    }

    /// <remarks/>
    public byte id
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
}
    }
}
