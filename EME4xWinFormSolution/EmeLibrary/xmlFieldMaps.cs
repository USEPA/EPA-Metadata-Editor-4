using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;


namespace EmeLibrary
{
    public class xmlFieldMaps
    {
        //Read data from a contacts xml data file

        public dcatElements basicInfo { get; set; }
        
        public xmlFieldMaps()
        { 
        }
        /// <summary>
        /// Pass in the xml file
        /// </summary>
        /// <param name="filepath"></param>
        public xmlFieldMaps(string filepath)
        {
            //set nodes


        }
        //gmd:MD_Metadata or gmi:MI_Metadata
        //<gmd:fileIdentifier>
        //<gmd:language>
        ////<gmd:characterSet> *From more complete Record
        //<gmd:hierarchyLevel>
        //<gmd:contact>
        //<gmd:dateStamp>
        //<gmd:metadataStandardName>
        //<gmd:metadataStandardVersion>
        ////<gmd:spatialRepresentationInfo>*repeated
        ////<gmd:referenceSystemInfo>*repeated
        //<gmd:identificationInfo>
        ////<gmd:contentInfo>
        //<gmd:distributionInfo>
        ////<gmd:dataQualityInfo>
        ////<gmd:metadataMaintenance>

    }

    public class dcatElements
    {
        public string m_title { get; set; }
        public string m_abstract { get; set; }
        public string m_keywords{ get; set; }
        public string m_dateModifed { get; set; }
        public string m_publisher { get; set; }
        public string m_person { get; set; }
        public string m_mbox { get; set; }
        public string m_identifier { get; set; }
        public string m_accessLevel { get; set; }
        public string m_dataDictionary { get; set; }
        public string m_webService { get; set; }
        public string m_format { get; set; }
        public string m_license { get; set; }
        public spatialEnvelope m_spatial { get; set; }
        public temporalRange m_temportal { get; set; }

    }
    public class spatialEnvelope
    {        
        public double m_minx { get; set; }
        public double m_miny { get; set; }
        public double m_maxx { get; set; }
        public double m_maxy { get; set; }        
    }
    public class temporalRange    
    {
        public DateTime m_beginDate { get; set; }
        public DateTime m_endDate { get; set; }
    }
}
