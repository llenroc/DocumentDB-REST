﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using Newtonsoft.Json.Linq;

namespace DocumentDBRestApi.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class ExcludePaths
    {
        /// <summary>
        ///     Initializes a new instance of the ExcludePaths class.
        /// </summary>
        public ExcludePaths()
        {
        }

        /// <summary>
        ///     Initializes a new instance of the ExcludePaths class with required
        ///     arguments.
        /// </summary>
        public ExcludePaths(string path)
            : this()
        {
            if (path == null)
            {
                throw new ArgumentNullException(nameof(path));
            }
            Path = path;
        }

        /// <summary>
        ///     Required. The accepted value is a valid document path including
        ///     wildcards values of ? and *.
        /// </summary>
        public string Path { get; set; }

        /// <summary>
        ///     Deserialize the object
        /// </summary>
        public virtual void DeserializeJson(JToken inputObject)
        {
            if (inputObject != null && inputObject.Type != JTokenType.Null)
            {
                var pathValue = inputObject["Path"];
                if (pathValue != null && pathValue.Type != JTokenType.Null)
                {
                    Path = (string) pathValue;
                }
            }
        }
    }
}