using System;
using System.Text.Json.Serialization;

namespace TemplateShared
{
    public class EntitySummary
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }

        [JsonPropertyName("displayDescription")]
        public string DisplayDescription { get; set; }

        [JsonPropertyName("version")]
        public string Version { get; set; }

        [JsonPropertyName("lockedBy")]
        public string LockedBy { get; set; }

        [JsonPropertyName("createdBy")]
        public string CreatedBy { get; set; }

        [JsonPropertyName("createdDate")]
        public string CreatedDate { get; set; }

        [JsonPropertyName("formattedCreatedDate")]
        public string FormattedCreatedDate { get; set; }

        [JsonPropertyName("modifiedBy")]
        public string ModifiedBy { get; set; }

        [JsonPropertyName("modifiedDate")]
        public string ModifiedDate { get; set; }

        [JsonPropertyName("formattedModifiedDate")]
        public string FormattedModifiedDate { get; set; }

        [JsonPropertyName("resourceUrl")]
        public string ResourceUrl { get; set; }

        [JsonPropertyName("entityTypeId")]
        public string EntityTypeId { get; set; }

        [JsonPropertyName("entityTypeDisplayName")]
        public string EntityTypeDisplayName { get; set; }

        [JsonPropertyName("completeness")]
        public int? Completeness { get; set; }

        [JsonPropertyName("fieldSetId")]
        public string FieldSetId { get; set; }

        [JsonPropertyName("fieldSetName")]
        public string FieldSetName { get; set; }

        [JsonPropertyName("segmentId")]
        public int SegmentId { get; set; }

        [JsonPropertyName("segmentName")]
        public string SegmentName { get; set; }
    }
}
