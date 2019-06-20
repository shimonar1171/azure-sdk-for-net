// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.WebSites.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Web Job Information.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class WebJob : ProxyOnlyResource
    {
        /// <summary>
        /// Initializes a new instance of the WebJob class.
        /// </summary>
        public WebJob()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the WebJob class.
        /// </summary>
        /// <param name="id">Resource Id.</param>
        /// <param name="name">Resource Name.</param>
        /// <param name="kind">Kind of resource.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="runCommand">Run command.</param>
        /// <param name="url">Job URL.</param>
        /// <param name="extraInfoUrl">Extra Info URL.</param>
        /// <param name="webJobType">Job type. Possible values include:
        /// 'Continuous', 'Triggered'</param>
        /// <param name="error">Error information.</param>
        /// <param name="usingSdk">Using SDK?</param>
        /// <param name="settings">Job settings.</param>
        public WebJob(string id = default(string), string name = default(string), string kind = default(string), string type = default(string), string runCommand = default(string), string url = default(string), string extraInfoUrl = default(string), WebJobType? webJobType = default(WebJobType?), string error = default(string), bool? usingSdk = default(bool?), IDictionary<string, object> settings = default(IDictionary<string, object>))
            : base(id, name, kind, type)
        {
            RunCommand = runCommand;
            Url = url;
            ExtraInfoUrl = extraInfoUrl;
            WebJobType = webJobType;
            Error = error;
            UsingSdk = usingSdk;
            Settings = settings;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets run command.
        /// </summary>
        [JsonProperty(PropertyName = "properties.run_command")]
        public string RunCommand { get; set; }

        /// <summary>
        /// Gets or sets job URL.
        /// </summary>
        [JsonProperty(PropertyName = "properties.url")]
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets extra Info URL.
        /// </summary>
        [JsonProperty(PropertyName = "properties.extra_info_url")]
        public string ExtraInfoUrl { get; set; }

        /// <summary>
        /// Gets or sets job type. Possible values include: 'Continuous',
        /// 'Triggered'
        /// </summary>
        [JsonProperty(PropertyName = "properties.web_job_type")]
        public WebJobType? WebJobType { get; set; }

        /// <summary>
        /// Gets or sets error information.
        /// </summary>
        [JsonProperty(PropertyName = "properties.error")]
        public string Error { get; set; }

        /// <summary>
        /// Gets or sets using SDK?
        /// </summary>
        [JsonProperty(PropertyName = "properties.using_sdk")]
        public bool? UsingSdk { get; set; }

        /// <summary>
        /// Gets or sets job settings.
        /// </summary>
        [JsonProperty(PropertyName = "properties.settings")]
        public IDictionary<string, object> Settings { get; set; }

    }
}