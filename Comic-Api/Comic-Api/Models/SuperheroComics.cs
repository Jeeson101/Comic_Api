namespace Comic_Api.Models
{
	public class SuperheroComics
	{
		public response _response { get; set; } = new response();
		public responseVolume[] _responseVolume { get; set; } = new responseVolume[1000000];

		// NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
		/// <remarks/>
		[System.SerializableAttribute()]
		[System.ComponentModel.DesignerCategoryAttribute("code")]
		[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
		[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
		public partial class response
		{

			private string errorField;

			private byte limitField;

			private byte offsetField;

			private byte number_of_page_resultsField;

			private uint number_of_total_resultsField;

			private byte status_codeField;

			private responseVolume[] resultsField;

			private decimal versionField;

			/// <remarks/>
			public string error
			{
				get
				{
					return this.errorField;
				}
				set
				{
					this.errorField = value;
				}
			}

			/// <remarks/>
			public byte limit
			{
				get
				{
					return this.limitField;
				}
				set
				{
					this.limitField = value;
				}
			}

			/// <remarks/>
			public byte offset
			{
				get
				{
					return this.offsetField;
				}
				set
				{
					this.offsetField = value;
				}
			}

			/// <remarks/>
			public byte number_of_page_results
			{
				get
				{
					return this.number_of_page_resultsField;
				}
				set
				{
					this.number_of_page_resultsField = value;
				}
			}

			/// <remarks/>
			public uint number_of_total_results
			{
				get
				{
					return this.number_of_total_resultsField;
				}
				set
				{
					this.number_of_total_resultsField = value;
				}
			}

			/// <remarks/>
			public byte status_code
			{
				get
				{
					return this.status_codeField;
				}
				set
				{
					this.status_codeField = value;
				}
			}

			/// <remarks/>
			[System.Xml.Serialization.XmlArrayItemAttribute("volume", IsNullable = false)]
			public responseVolume[] results
			{
				get
				{
					return this.resultsField;
				}
				set
				{
					this.resultsField = value;
				}
			}

			/// <remarks/>
			public decimal version
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
		}

		/// <remarks/>
		[System.SerializableAttribute()]
		[System.ComponentModel.DesignerCategoryAttribute("code")]
		[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
		public partial class responseVolume
		{

			private string aliasesField;

			private string api_detail_urlField;

			private ushort count_of_issuesField;

			private string date_addedField;

			private string date_last_updatedField;

			private string deckField;

			private string descriptionField;

			private responseVolumeFirst_issue first_issueField;

			private ushort idField;

			private responseVolumeImage imageField;

			private responseVolumeLast_issue last_issueField;

			private string nameField;

			private responseVolumePublisher publisherField;

			private string site_detail_urlField;

			private ushort start_yearField;

			/// <remarks/>
			public string aliases
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
			public ushort count_of_issues
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
			public string deck
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
			public responseVolumeFirst_issue first_issue
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
			public responseVolumeImage image
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
			public responseVolumeLast_issue last_issue
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
			public responseVolumePublisher publisher
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
		public partial class responseVolumeFirst_issue
		{

			private string api_detail_urlField;

			private uint idField;

			private string nameField;

			private string issue_numberField;

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
			public string issue_number
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
		public partial class responseVolumeImage
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
		public partial class responseVolumeLast_issue
		{

			private string api_detail_urlField;

			private uint idField;

			private string nameField;

			private uint issue_numberField;

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
			public uint issue_number
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
		public partial class responseVolumePublisher
		{

			private string api_detail_urlField;

			private ushort idField;

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
