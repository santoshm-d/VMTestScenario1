namespace VirginScenario.Domain
{

    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class Data
    {

        private XMLInputSchema[] scenarioField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Scenario")]
        public XMLInputSchema[] Scenario
        {
            get
            {
                return this.scenarioField;
            }
            set
            {
                this.scenarioField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class XMLInputSchema
    {

        private byte scenarioIDField;

        private string nameField;

        private string surnameField;

        private string forenameField;

        private string userIDField;

        private DateTime sampleDateField;

        private string creationDateField;

        private byte numMonthsField;

        private byte marketIDField;

        private bool marketIDFieldSpecified;

        private byte networkLayerIDField;

        private bool networkLayerIDFieldSpecified;

        public XMLInputSchema() { }

        public XMLInputSchema(byte scenarioIDField, string nameField, string surnameField, string forenameField, string userIDField, DateTime sampleDateField, string creationDateField, byte numMonthsField, byte marketIDField, bool marketIDFieldSpecified, byte networkLayerIDField, bool networkLayerIDFieldSpecified, byte scenarioID, string name, string surname, string forename, string userID, DateTime sampleDate, string creationDate, byte numMonths, byte marketID, bool marketIDSpecified, byte networkLayerID, bool networkLayerIDSpecified)
        {
            this.scenarioIDField = scenarioIDField;
            this.nameField = nameField;
            this.surnameField = surnameField;
            this.forenameField = forenameField;
            this.userIDField = userIDField;
            this.sampleDateField = sampleDateField;
            this.creationDateField = creationDateField;
            this.numMonthsField = numMonthsField;
            this.marketIDField = marketIDField;
            this.marketIDFieldSpecified = marketIDFieldSpecified;
            this.networkLayerIDField = networkLayerIDField;
            this.networkLayerIDFieldSpecified = networkLayerIDFieldSpecified;
            ScenarioID = scenarioID;
            Name = name;
            Surname = surname;
            Forename = forename;
            UserID = userID;
            SampleDate = sampleDate;
            CreationDate = creationDate;
            NumMonths = numMonths;
            MarketID = marketID;
            MarketIDSpecified = marketIDSpecified;
            NetworkLayerID = networkLayerID;
            NetworkLayerIDSpecified = networkLayerIDSpecified;
        }

        public byte ScenarioID
        {
            get
            {
                return this.scenarioIDField;
            }
            set
            {
                this.scenarioIDField = value;
            }
        }
        public string Name
        {
            get
            {
                return nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
        public string Surname
        {
            get
            {
                return surnameField;
            }
            set
            {
                this.surnameField = value;
            }
        }
        public string Forename
        {
            get
            {
                return forenameField;
            }
            set
            {
                this.forenameField = value;
            }
        }
        public string UserID
        {
            get
            {
                return this.userIDField;
            }
            set
            {
                this.userIDField = value;
            }
        }
        public System.DateTime SampleDate
        {
            get
            {
                return this.sampleDateField;
            }
            set
            {
                this.sampleDateField = value;
            }
        }
        public string CreationDate
        {
            get
            {
                return this.creationDateField;
            }
            set
            {
                this.creationDateField = value;
            }
        }

        public byte NumMonths
        {
            get
            {
                return this.numMonthsField;
            }
            set
            {
                this.numMonthsField = value;
            }
        }
        public byte MarketID
        {
            get
            {
                return this.marketIDField;
            }
            set
            {
                this.marketIDField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MarketIDSpecified
        {
            get
            {
                return this.marketIDFieldSpecified;
            }
            set
            {
                this.marketIDFieldSpecified = value;
            }
        }
        public byte NetworkLayerID
        {
            get
            {
                return this.networkLayerIDField;
            }
            set
            {
                this.networkLayerIDField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NetworkLayerIDSpecified
        {
            get
            {
                return this.networkLayerIDFieldSpecified;
            }
            set
            {
                this.networkLayerIDFieldSpecified = value;
            }
        }
    }



}