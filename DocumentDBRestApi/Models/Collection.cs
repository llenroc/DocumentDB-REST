﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using Newtonsoft.Json.Linq;

namespace DocumentDBRestApi.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class Collection
    {
        /// <summary>
        ///     Required. This is a system generated property that specifies the
        ///     addressable path of the conflicts resource. During an operation on
        ///     a resource within a collection, if a conflict occurs, users can
        ///     inspect the conflicting resources by performing a GET on the
        ///     conflicts URI path.
        /// </summary>
        public string Conflicts { get; set; }

        /// <summary>
        ///     Required. This is a system generated property that specifies the
        ///     addressable path of the documents resource.
        /// </summary>
        public string Doc { get; set; }

        /// <summary>
        ///     Required. This is a system generated property that specifies the
        ///     resource etag required for optimistic concurrency control.
        /// </summary>
        public string Etag { get; set; }

        /// <summary>
        ///     Required. This is a system generated property. The resource Id
        ///     (_rid) is a unique identifier that is also hierarchical per the
        ///     resource stack on the resource model. It is used internally for
        ///     placement and navigation of the collection resource.
        /// </summary>
        public string Rid { get; set; }

        /// <summary>
        ///     Required. This is a system generated property. It is the unique
        ///     addressable URI for the resource.
        /// </summary>
        public string Self { get; set; }

        /// <summary>
        ///     Required. This is a system generated property that specifies the
        ///     addressable path of the stored procedures (sprocs) resource.
        /// </summary>
        public string Sprocs { get; set; }

        /// <summary>
        ///     Required. This is a system generated property that specifies the
        ///     addressable path of the triggers resource
        /// </summary>
        public string Triggers { get; set; }

        /// <summary>
        ///     Required. This is a system generated property. It specifies the
        ///     last updated timestamp of the resource. The value is a timestamp.
        /// </summary>
        public string Ts { get; set; }

        /// <summary>
        ///     Required. This is a system generated property that specifies the
        ///     addressable path of the user-defined functions (udfs) resource.
        /// </summary>
        public string Udfs { get; set; }

        /// <summary>
        ///     Required. This is a user settable property. It is the unique name
        ///     that identifies a collection, i.e. no two collections share the
        ///     same id. The id must not exceed 255 characters.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        ///     Optional. This is the indexing policy setting for the collection.
        ///     All properties in the indexingPolicy are user settable.
        /// </summary>
        public IndexingPolicy IndexingPolicy { get; set; }

        /// <summary>
        ///     Deserialize the object
        /// </summary>
        public virtual void DeserializeJson(JToken inputObject)
        {
            if (inputObject == null || inputObject.Type == JTokenType.Null) return;
            var conflictsValue = inputObject["_conflicts"];
            if (conflictsValue != null && conflictsValue.Type != JTokenType.Null)
            {
                Conflicts = (string) conflictsValue;
            }
            var docValue = inputObject["_doc"];
            if (docValue != null && docValue.Type != JTokenType.Null)
            {
                Doc = (string) docValue;
            }
            var etagValue = inputObject["_etag"];
            if (etagValue != null && etagValue.Type != JTokenType.Null)
            {
                Etag = (string) etagValue;
            }
            var ridValue = inputObject["_rid"];
            if (ridValue != null && ridValue.Type != JTokenType.Null)
            {
                Rid = (string) ridValue;
            }
            var selfValue = inputObject["_self"];
            if (selfValue != null && selfValue.Type != JTokenType.Null)
            {
                Self = (string) selfValue;
            }
            var sprocsValue = inputObject["_sprocs"];
            if (sprocsValue != null && sprocsValue.Type != JTokenType.Null)
            {
                Sprocs = (string) sprocsValue;
            }
            var triggersValue = inputObject["_triggers"];
            if (triggersValue != null && triggersValue.Type != JTokenType.Null)
            {
                Triggers = (string) triggersValue;
            }
            var tsValue = inputObject["_ts"];
            if (tsValue != null && tsValue.Type != JTokenType.Null)
            {
                Ts = (string) tsValue;
            }
            var udfsValue = inputObject["_udfs"];
            if (udfsValue != null && udfsValue.Type != JTokenType.Null)
            {
                Udfs = (string) udfsValue;
            }
            var idValue = inputObject["id"];
            if (idValue != null && idValue.Type != JTokenType.Null)
            {
                Id = (string) idValue;
            }
            var indexingPolicyValue = inputObject["indexingPolicy"];
            if (indexingPolicyValue != null && indexingPolicyValue.Type != JTokenType.Null)
            {
                var indexingPolicy = new IndexingPolicy();
                indexingPolicy.DeserializeJson(indexingPolicyValue);
                IndexingPolicy = indexingPolicy;
            }
        }
    }
}