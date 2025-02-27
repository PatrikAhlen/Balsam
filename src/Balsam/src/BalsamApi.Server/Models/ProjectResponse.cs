/*
 * BalsamApi
 *
 * This is the API for createing Baslam artifcats.
 *
 * The version of the OpenAPI document: 2.0
 * 
 * Generated by: https://openapi-generator.tech
 */

using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using BalsamApi.Server.Converters;

namespace BalsamApi.Server.Models
{ 
    /// <summary>
    /// Project created response
    /// </summary>
    [DataContract]
    public class ProjectResponse : IEquatable<ProjectResponse>
    {
        /// <summary>
        /// URL to the git repository
        /// </summary>
        /// <value>URL to the git repository</value>
        [Required]
        [DataMember(Name="gitUrl", EmitDefaultValue=false)]
        public string GitUrl { get; set; }

        /// <summary>
        /// The identifier
        /// </summary>
        /// <value>The identifier</value>
        [Required]
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// The name
        /// </summary>
        /// <value>The name</value>
        [Required]
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Description of the project
        /// </summary>
        /// <value>Description of the project</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Branches
        /// </summary>
        [DataMember(Name="branches", EmitDefaultValue=false)]
        public List<Branch> Branches { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProjectResponse {\n");
            sb.Append("  GitUrl: ").Append(GitUrl).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Branches: ").Append(Branches).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((ProjectResponse)obj);
        }

        /// <summary>
        /// Returns true if ProjectResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ProjectResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProjectResponse other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    GitUrl == other.GitUrl ||
                    GitUrl != null &&
                    GitUrl.Equals(other.GitUrl)
                ) && 
                (
                    Id == other.Id ||
                    Id != null &&
                    Id.Equals(other.Id)
                ) && 
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) && 
                (
                    Description == other.Description ||
                    Description != null &&
                    Description.Equals(other.Description)
                ) && 
                (
                    Branches == other.Branches ||
                    Branches != null &&
                    other.Branches != null &&
                    Branches.SequenceEqual(other.Branches)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (GitUrl != null)
                    hashCode = hashCode * 59 + GitUrl.GetHashCode();
                    if (Id != null)
                    hashCode = hashCode * 59 + Id.GetHashCode();
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                    if (Branches != null)
                    hashCode = hashCode * 59 + Branches.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ProjectResponse left, ProjectResponse right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ProjectResponse left, ProjectResponse right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
