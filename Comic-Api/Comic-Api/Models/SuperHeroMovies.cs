namespace Comic_Api.Models
{
	public class SuperHeroMovies
	{
		public response _response { get; set; }


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

			private byte number_of_total_resultsField;

			private byte status_codeField;

			private responseResults resultsField;

			private decimal versionField;

			/// <remarks/>
			public string error
			{
				get { return this.errorField; }
				set { this.errorField = value; }
			}

			/// <remarks/>
			public byte limit
			{
				get { return this.limitField; }
				set { this.limitField = value; }
			}

			/// <remarks/>
			public byte offset
			{
				get { return this.offsetField; }
				set { this.offsetField = value; }
			}

			/// <remarks/>
			public byte number_of_page_results
			{
				get { return this.number_of_page_resultsField; }
				set { this.number_of_page_resultsField = value; }
			}

			/// <remarks/>
			public byte number_of_total_results
			{
				get { return this.number_of_total_resultsField; }
				set { this.number_of_total_resultsField = value; }
			}

			/// <remarks/>
			public byte status_code
			{
				get { return this.status_codeField; }
				set { this.status_codeField = value; }
			}

			/// <remarks/>
			public responseResults results
			{
				get { return this.resultsField; }
				set { this.resultsField = value; }
			}

			/// <remarks/>
			public decimal version
			{
				get { return this.versionField; }
				set { this.versionField = value; }
			}
		}

		/// <remarks/>
		[System.SerializableAttribute()]
		[System.ComponentModel.DesignerCategoryAttribute("code")]
		[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
		public partial class responseResults
		{

			private responseResultsMovie movieField;

			/// <remarks/>
			public responseResultsMovie movie
			{
				get { return this.movieField; }
				set { this.movieField = value; }
			}
		}

		/// <remarks/>
		[System.SerializableAttribute()]
		[System.ComponentModel.DesignerCategoryAttribute("code")]
		[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
		public partial class responseResultsMovie
		{

			private string api_detail_urlField;

			private string box_office_revenueField;

			private string budgetField;

			private string date_addedField;

			private string date_last_updatedField;

			private string deckField;

			private string descriptionField;

			private object distributorField;

			private object has_staff_reviewField;

			private byte idField;

			private responseResultsMovieImage imageField;

			private string nameField;

			private responseResultsMovieProducers producersField;

			private string ratingField;

			private string release_dateField;

			private byte runtimeField;

			private string site_detail_urlField;

			private responseResultsMovieStudios studiosField;

			private string total_revenueField;

			private responseResultsMovieWriters writersField;

			/// <remarks/>
			public string api_detail_url
			{
				get { return this.api_detail_urlField; }
				set { this.api_detail_urlField = value; }
			}

			/// <remarks/>
			public string box_office_revenue
			{
				get { return this.box_office_revenueField; }
				set { this.box_office_revenueField = value; }
			}

			/// <remarks/>
			public string budget
			{
				get { return this.budgetField; }
				set { this.budgetField = value; }
			}

			/// <remarks/>
			public string date_added
			{
				get { return this.date_addedField; }
				set { this.date_addedField = value; }
			}

			/// <remarks/>
			public string date_last_updated
			{
				get { return this.date_last_updatedField; }
				set { this.date_last_updatedField = value; }
			}

			/// <remarks/>
			public string deck
			{
				get { return this.deckField; }
				set { this.deckField = value; }
			}

			/// <remarks/>
			public string description
			{
				get { return this.descriptionField; }
				set { this.descriptionField = value; }
			}

			/// <remarks/>
			public object distributor
			{
				get { return this.distributorField; }
				set { this.distributorField = value; }
			}

			/// <remarks/>
			public object has_staff_review
			{
				get { return this.has_staff_reviewField; }
				set { this.has_staff_reviewField = value; }
			}

			/// <remarks/>
			public byte id
			{
				get { return this.idField; }
				set { this.idField = value; }
			}

			/// <remarks/>
			public responseResultsMovieImage image
			{
				get { return this.imageField; }
				set { this.imageField = value; }
			}

			/// <remarks/>
			public string name
			{
				get { return this.nameField; }
				set { this.nameField = value; }
			}

			/// <remarks/>
			public responseResultsMovieProducers producers
			{
				get { return this.producersField; }
				set { this.producersField = value; }
			}

			/// <remarks/>
			public string rating
			{
				get { return this.ratingField; }
				set { this.ratingField = value; }
			}

			/// <remarks/>
			public string release_date
			{
				get { return this.release_dateField; }
				set { this.release_dateField = value; }
			}

			/// <remarks/>
			public byte runtime
			{
				get { return this.runtimeField; }
				set { this.runtimeField = value; }
			}

			/// <remarks/>
			public string site_detail_url
			{
				get { return this.site_detail_urlField; }
				set { this.site_detail_urlField = value; }
			}

			/// <remarks/>
			public responseResultsMovieStudios studios
			{
				get { return this.studiosField; }
				set { this.studiosField = value; }
			}

			/// <remarks/>
			public string total_revenue
			{
				get { return this.total_revenueField; }
				set { this.total_revenueField = value; }
			}

			/// <remarks/>
			public responseResultsMovieWriters writers
			{
				get { return this.writersField; }
				set { this.writersField = value; }
			}
		}

		/// <remarks/>
		[System.SerializableAttribute()]
		[System.ComponentModel.DesignerCategoryAttribute("code")]
		[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
		public partial class responseResultsMovieImage
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
				get { return this.icon_urlField; }
				set { this.icon_urlField = value; }
			}

			/// <remarks/>
			public string medium_url
			{
				get { return this.medium_urlField; }
				set { this.medium_urlField = value; }
			}

			/// <remarks/>
			public string screen_url
			{
				get { return this.screen_urlField; }
				set { this.screen_urlField = value; }
			}

			/// <remarks/>
			public string screen_large_url
			{
				get { return this.screen_large_urlField; }
				set { this.screen_large_urlField = value; }
			}

			/// <remarks/>
			public string small_url
			{
				get { return this.small_urlField; }
				set { this.small_urlField = value; }
			}

			/// <remarks/>
			public string super_url
			{
				get { return this.super_urlField; }
				set { this.super_urlField = value; }
			}

			/// <remarks/>
			public string thumb_url
			{
				get { return this.thumb_urlField; }
				set { this.thumb_urlField = value; }
			}

			/// <remarks/>
			public string tiny_url
			{
				get { return this.tiny_urlField; }
				set { this.tiny_urlField = value; }
			}

			/// <remarks/>
			public string original_url
			{
				get { return this.original_urlField; }
				set { this.original_urlField = value; }
			}

			/// <remarks/>
			public string image_tags
			{
				get { return this.image_tagsField; }
				set { this.image_tagsField = value; }
			}
		}

		/// <remarks/>
		[System.SerializableAttribute()]
		[System.ComponentModel.DesignerCategoryAttribute("code")]
		[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
		public partial class responseResultsMovieProducers
		{

			private object[] itemsField;

			private ItemsChoiceType[] itemsElementNameField;

			/// <remarks/>
			[System.Xml.Serialization.XmlElementAttribute("api_detail_url", typeof(string))]
			[System.Xml.Serialization.XmlElementAttribute("id", typeof(uint))]
			[System.Xml.Serialization.XmlElementAttribute("name", typeof(string))]
			[System.Xml.Serialization.XmlElementAttribute("site_detail_url", typeof(string))]
			[System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
			public object[] Items
			{
				get { return this.itemsField; }
				set { this.itemsField = value; }
			}

			/// <remarks/>
			[System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
			[System.Xml.Serialization.XmlIgnoreAttribute()]
			public ItemsChoiceType[] ItemsElementName
			{
				get { return this.itemsElementNameField; }
				set { this.itemsElementNameField = value; }
			}
		}

		/// <remarks/>
		[System.SerializableAttribute()]
		[System.Xml.Serialization.XmlTypeAttribute(IncludeInSchema = false)]
		public enum ItemsChoiceType
		{

			/// <remarks/>
			api_detail_url,

			/// <remarks/>
			id,

			/// <remarks/>
			name,

			/// <remarks/>
			site_detail_url,
		}

		/// <remarks/>
		[System.SerializableAttribute()]
		[System.ComponentModel.DesignerCategoryAttribute("code")]
		[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
		public partial class responseResultsMovieStudios
		{

			private string api_detail_urlField;

			private ushort idField;

			private string nameField;

			private string site_detail_urlField;

			/// <remarks/>
			public string api_detail_url
			{
				get { return this.api_detail_urlField; }
				set { this.api_detail_urlField = value; }
			}

			/// <remarks/>
			public ushort id
			{
				get { return this.idField; }
				set { this.idField = value; }
			}

			/// <remarks/>
			public string name
			{
				get { return this.nameField; }
				set { this.nameField = value; }
			}

			/// <remarks/>
			public string site_detail_url
			{
				get { return this.site_detail_urlField; }
				set { this.site_detail_urlField = value; }
			}
		}

		/// <remarks/>
		[System.SerializableAttribute()]
		[System.ComponentModel.DesignerCategoryAttribute("code")]
		[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
		public partial class responseResultsMovieWriters
		{

			private object[] itemsField;

			private ItemsChoiceType1[] itemsElementNameField;

			/// <remarks/>
			[System.Xml.Serialization.XmlElementAttribute("api_detail_url", typeof(string))]
			[System.Xml.Serialization.XmlElementAttribute("id", typeof(uint))]
			[System.Xml.Serialization.XmlElementAttribute("name", typeof(string))]
			[System.Xml.Serialization.XmlElementAttribute("site_detail_url", typeof(string))]
			[System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
			public object[] Items
			{
				get { return this.itemsField; }
				set { this.itemsField = value; }
			}

			/// <remarks/>
			[System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
			[System.Xml.Serialization.XmlIgnoreAttribute()]
			public ItemsChoiceType1[] ItemsElementName
			{
				get { return this.itemsElementNameField; }
				set { this.itemsElementNameField = value; }
			}
		}

		/// <remarks/>
		[System.SerializableAttribute()]
		[System.Xml.Serialization.XmlTypeAttribute(IncludeInSchema = false)]
		public enum ItemsChoiceType1
		{

			/// <remarks/>
			api_detail_url,

			/// <remarks/>
			id,

			/// <remarks/>
			name,

			/// <remarks/>
			site_detail_url,
		}

	}
}


