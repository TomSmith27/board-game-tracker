namespace BoardGame.Api.Dto
{
    using System;
    using System.Collections.Generic;
    using System.Xml.Serialization;

    [XmlRoot(ElementName = "name")]
    public class Name
    {
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "boardgame")]
    public class Boardgame
    {
        [XmlElement(ElementName = "name")]
        public Name Name { get; set; }
        [XmlElement(ElementName = "yearpublished")]
        public string Yearpublished { get; set; }
        [XmlAttribute(AttributeName = "objectid")]
        public string Objectid { get; set; }
    }

    [Serializable]
    [XmlRoot(ElementName = "boardgames", Namespace = "")]
    public class BoardgameSearchResult
    {
        [XmlElement(ElementName = "boardgame")]
        public List<Boardgame> Boardgames { get; set; }
    }

}
