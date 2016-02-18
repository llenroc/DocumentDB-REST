﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using Newtonsoft.Json.Linq;

namespace DocumentDBRestApi.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class CustomBody
    {
        /// <summary>
        ///     Optional. A JSON array of parameters specified as name value pairs.
        /// </summary>
        public string Custom { get; set; }

        /// <summary>
        ///     Serialize the object
        /// </summary>
        /// <returns>
        ///     Returns the json model for the type CustomBody
        /// </returns>
        public virtual JToken SerializeJson(JToken outputObject)
        {
            if (outputObject == null)
            {
                outputObject = new JObject();
            }
            if (Custom != null)
            {
                outputObject["custom"] = Custom;
            }
            return outputObject;
        }
    }
}