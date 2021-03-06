﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Collections.Generic;
using Microsoft.WindowsAzure.Common.Internals;
using Newtonsoft.Json.Linq;

namespace DocumentDBRestAPIClient.Models
{
    public class QueryRequest
    {
        /// <summary>
        ///     Initializes a new instance of the QueryRequest class.
        /// </summary>
        public QueryRequest()
        {
            Parameters = new LazyList<string>();
        }

        /// <summary>
        ///     Initializes a new instance of the QueryRequest class with required
        ///     arguments.
        /// </summary>
        public QueryRequest(string query, IList<string> parameters)
            : this()
        {
            if (query == null)
            {
                throw new ArgumentNullException(nameof(query));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }
            Query = query;
            Parameters = parameters;
        }

        /// <summary>
        ///     Required. A JSON array of parameters specified as name value pairs.
        ///     The parameter array can contain from zero to many parameters.Each
        ///     parameter must have the following values:name: the name of the
        ///     parameter. Parameter names must be valid string literals and begin
        ///     with ‘@’.value: the value of the parameter. Can be any valid JSON
        ///     value (string, number, object, array, Boolean or null).
        /// </summary>
        public IList<string> Parameters { get; set; }

        /// <summary>
        ///     Required. The SQL query string for the query
        /// </summary>
        public string Query { get; set; }

        /// <summary>
        ///     Serialize the object
        /// </summary>
        /// <returns>
        ///     Returns the json model for the type QueryRequest
        /// </returns>
        public virtual JToken SerializeJson(JToken outputObject)
        {
            if (outputObject == null)
            {
                outputObject = new JObject();
            }
            var collection = Parameters as ILazyCollection;
            if (collection != null && collection.IsInitialized == false ||
                Parameters == null)
            {
                throw new ArgumentNullException(nameof(Parameters));
            }
            if (Query == null)
            {
                throw new ArgumentNullException(nameof(Query));
            }
            if (Parameters != null)
            {
                var lazyCollection = Parameters as ILazyCollection;
                if (lazyCollection != null == false ||
                    (Parameters as ILazyCollection).IsInitialized)
                {
                    var parametersSequence = new JArray();
                    outputObject["parameters"] = parametersSequence;
                    foreach (var parametersItem in Parameters)
                    {
                        if (parametersItem != null)
                        {
                            parametersSequence.Add(parametersItem);
                        }
                    }
                }
            }
            if (Query != null)
            {
                outputObject["query"] = Query;
            }
            return outputObject;
        }
    }
}