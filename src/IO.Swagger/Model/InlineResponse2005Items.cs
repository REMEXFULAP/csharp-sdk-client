/* 
 * REMESITA API REST
 *
 * Api de remesita.com para desarrolladores. Primero obten tu apiKey y apiSecret, y para autenticarte debes ejecutar el endpoint rest/v1/auth en la respuesta obtendrás un token de acceso que debes usar en el resto de peticiones
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// InlineResponse2005Items
    /// </summary>
    [DataContract]
    public partial class InlineResponse2005Items :  IEquatable<InlineResponse2005Items>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse2005Items" /> class.
        /// </summary>
        /// <param name="status">status.</param>
        /// <param name="speedMode">speedMode.</param>
        /// <param name="reference">reference.</param>
        /// <param name="sku">sku.</param>
        /// <param name="recipientAccount">recipientAccount.</param>
        /// <param name="swift">swift.</param>
        /// <param name="institution">institution.</param>
        /// <param name="senderName">senderName.</param>
        /// <param name="senderCountry">senderCountry.</param>
        /// <param name="recipientName">recipientName.</param>
        /// <param name="recipientCountry">recipientCountry.</param>
        /// <param name="recipientRelationship">recipientRelationship.</param>
        /// <param name="paymentMethod">paymentMethod.</param>
        /// <param name="quotation">quotation.</param>
        /// <param name="senderCurrency">senderCurrency.</param>
        /// <param name="exchangeRate">exchangeRate.</param>
        /// <param name="lifeTime">lifeTime.</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="payedAt">payedAt.</param>
        /// <param name="cancelAt">cancelAt.</param>
        /// <param name="completedAt">completedAt.</param>
        /// <param name="institutionIcon">institutionIcon.</param>
        /// <param name="cancelReason">cancelReason.</param>
        /// <param name="intent">intent.</param>
        public InlineResponse2005Items(string status = default(string), string speedMode = default(string), string reference = default(string), string sku = default(string), string recipientAccount = default(string), string swift = default(string), string institution = default(string), string senderName = default(string), string senderCountry = default(string), string recipientName = default(string), string recipientCountry = default(string), string recipientRelationship = default(string), string paymentMethod = default(string), string quotation = default(string), string senderCurrency = default(string), decimal? exchangeRate = default(decimal?), string lifeTime = default(string), DateTime? createdAt = default(DateTime?), DateTime? payedAt = default(DateTime?), DateTime? cancelAt = default(DateTime?), DateTime? completedAt = default(DateTime?), string institutionIcon = default(string), string cancelReason = default(string), string intent = default(string))
        {
            this.Status = status;
            this.SpeedMode = speedMode;
            this.Reference = reference;
            this.Sku = sku;
            this.RecipientAccount = recipientAccount;
            this.Swift = swift;
            this.Institution = institution;
            this.SenderName = senderName;
            this.SenderCountry = senderCountry;
            this.RecipientName = recipientName;
            this.RecipientCountry = recipientCountry;
            this.RecipientRelationship = recipientRelationship;
            this.PaymentMethod = paymentMethod;
            this.Quotation = quotation;
            this.SenderCurrency = senderCurrency;
            this.ExchangeRate = exchangeRate;
            this.LifeTime = lifeTime;
            this.CreatedAt = createdAt;
            this.PayedAt = payedAt;
            this.CancelAt = cancelAt;
            this.CompletedAt = completedAt;
            this.InstitutionIcon = institutionIcon;
            this.CancelReason = cancelReason;
            this.Intent = intent;
        }
        
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets SpeedMode
        /// </summary>
        [DataMember(Name="speedMode", EmitDefaultValue=false)]
        public string SpeedMode { get; set; }

        /// <summary>
        /// Gets or Sets Reference
        /// </summary>
        [DataMember(Name="reference", EmitDefaultValue=false)]
        public string Reference { get; set; }

        /// <summary>
        /// Gets or Sets Sku
        /// </summary>
        [DataMember(Name="sku", EmitDefaultValue=false)]
        public string Sku { get; set; }

        /// <summary>
        /// Gets or Sets RecipientAccount
        /// </summary>
        [DataMember(Name="recipientAccount", EmitDefaultValue=false)]
        public string RecipientAccount { get; set; }

        /// <summary>
        /// Gets or Sets Swift
        /// </summary>
        [DataMember(Name="swift", EmitDefaultValue=false)]
        public string Swift { get; set; }

        /// <summary>
        /// Gets or Sets Institution
        /// </summary>
        [DataMember(Name="institution", EmitDefaultValue=false)]
        public string Institution { get; set; }

        /// <summary>
        /// Gets or Sets SenderName
        /// </summary>
        [DataMember(Name="senderName", EmitDefaultValue=false)]
        public string SenderName { get; set; }

        /// <summary>
        /// Gets or Sets SenderCountry
        /// </summary>
        [DataMember(Name="senderCountry", EmitDefaultValue=false)]
        public string SenderCountry { get; set; }

        /// <summary>
        /// Gets or Sets RecipientName
        /// </summary>
        [DataMember(Name="recipientName", EmitDefaultValue=false)]
        public string RecipientName { get; set; }

        /// <summary>
        /// Gets or Sets RecipientCountry
        /// </summary>
        [DataMember(Name="recipientCountry", EmitDefaultValue=false)]
        public string RecipientCountry { get; set; }

        /// <summary>
        /// Gets or Sets RecipientRelationship
        /// </summary>
        [DataMember(Name="recipientRelationship", EmitDefaultValue=false)]
        public string RecipientRelationship { get; set; }

        /// <summary>
        /// Gets or Sets PaymentMethod
        /// </summary>
        [DataMember(Name="paymentMethod", EmitDefaultValue=false)]
        public string PaymentMethod { get; set; }

        /// <summary>
        /// Gets or Sets Quotation
        /// </summary>
        [DataMember(Name="quotation", EmitDefaultValue=false)]
        public string Quotation { get; set; }

        /// <summary>
        /// Gets or Sets SenderCurrency
        /// </summary>
        [DataMember(Name="senderCurrency", EmitDefaultValue=false)]
        public string SenderCurrency { get; set; }

        /// <summary>
        /// Gets or Sets ExchangeRate
        /// </summary>
        [DataMember(Name="exchangeRate", EmitDefaultValue=false)]
        public decimal? ExchangeRate { get; set; }

        /// <summary>
        /// Gets or Sets LifeTime
        /// </summary>
        [DataMember(Name="lifeTime", EmitDefaultValue=false)]
        public string LifeTime { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name="createdAt", EmitDefaultValue=false)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets PayedAt
        /// </summary>
        [DataMember(Name="payedAt", EmitDefaultValue=false)]
        public DateTime? PayedAt { get; set; }

        /// <summary>
        /// Gets or Sets CancelAt
        /// </summary>
        [DataMember(Name="cancelAt", EmitDefaultValue=false)]
        public DateTime? CancelAt { get; set; }

        /// <summary>
        /// Gets or Sets CompletedAt
        /// </summary>
        [DataMember(Name="completedAt", EmitDefaultValue=false)]
        public DateTime? CompletedAt { get; set; }

        /// <summary>
        /// Gets or Sets InstitutionIcon
        /// </summary>
        [DataMember(Name="institutionIcon", EmitDefaultValue=false)]
        public string InstitutionIcon { get; set; }

        /// <summary>
        /// Gets or Sets CancelReason
        /// </summary>
        [DataMember(Name="cancelReason", EmitDefaultValue=false)]
        public string CancelReason { get; set; }

        /// <summary>
        /// Gets or Sets Intent
        /// </summary>
        [DataMember(Name="intent", EmitDefaultValue=false)]
        public string Intent { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse2005Items {\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  SpeedMode: ").Append(SpeedMode).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  Sku: ").Append(Sku).Append("\n");
            sb.Append("  RecipientAccount: ").Append(RecipientAccount).Append("\n");
            sb.Append("  Swift: ").Append(Swift).Append("\n");
            sb.Append("  Institution: ").Append(Institution).Append("\n");
            sb.Append("  SenderName: ").Append(SenderName).Append("\n");
            sb.Append("  SenderCountry: ").Append(SenderCountry).Append("\n");
            sb.Append("  RecipientName: ").Append(RecipientName).Append("\n");
            sb.Append("  RecipientCountry: ").Append(RecipientCountry).Append("\n");
            sb.Append("  RecipientRelationship: ").Append(RecipientRelationship).Append("\n");
            sb.Append("  PaymentMethod: ").Append(PaymentMethod).Append("\n");
            sb.Append("  Quotation: ").Append(Quotation).Append("\n");
            sb.Append("  SenderCurrency: ").Append(SenderCurrency).Append("\n");
            sb.Append("  ExchangeRate: ").Append(ExchangeRate).Append("\n");
            sb.Append("  LifeTime: ").Append(LifeTime).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  PayedAt: ").Append(PayedAt).Append("\n");
            sb.Append("  CancelAt: ").Append(CancelAt).Append("\n");
            sb.Append("  CompletedAt: ").Append(CompletedAt).Append("\n");
            sb.Append("  InstitutionIcon: ").Append(InstitutionIcon).Append("\n");
            sb.Append("  CancelReason: ").Append(CancelReason).Append("\n");
            sb.Append("  Intent: ").Append(Intent).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as InlineResponse2005Items);
        }

        /// <summary>
        /// Returns true if InlineResponse2005Items instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineResponse2005Items to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse2005Items input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.SpeedMode == input.SpeedMode ||
                    (this.SpeedMode != null &&
                    this.SpeedMode.Equals(input.SpeedMode))
                ) && 
                (
                    this.Reference == input.Reference ||
                    (this.Reference != null &&
                    this.Reference.Equals(input.Reference))
                ) && 
                (
                    this.Sku == input.Sku ||
                    (this.Sku != null &&
                    this.Sku.Equals(input.Sku))
                ) && 
                (
                    this.RecipientAccount == input.RecipientAccount ||
                    (this.RecipientAccount != null &&
                    this.RecipientAccount.Equals(input.RecipientAccount))
                ) && 
                (
                    this.Swift == input.Swift ||
                    (this.Swift != null &&
                    this.Swift.Equals(input.Swift))
                ) && 
                (
                    this.Institution == input.Institution ||
                    (this.Institution != null &&
                    this.Institution.Equals(input.Institution))
                ) && 
                (
                    this.SenderName == input.SenderName ||
                    (this.SenderName != null &&
                    this.SenderName.Equals(input.SenderName))
                ) && 
                (
                    this.SenderCountry == input.SenderCountry ||
                    (this.SenderCountry != null &&
                    this.SenderCountry.Equals(input.SenderCountry))
                ) && 
                (
                    this.RecipientName == input.RecipientName ||
                    (this.RecipientName != null &&
                    this.RecipientName.Equals(input.RecipientName))
                ) && 
                (
                    this.RecipientCountry == input.RecipientCountry ||
                    (this.RecipientCountry != null &&
                    this.RecipientCountry.Equals(input.RecipientCountry))
                ) && 
                (
                    this.RecipientRelationship == input.RecipientRelationship ||
                    (this.RecipientRelationship != null &&
                    this.RecipientRelationship.Equals(input.RecipientRelationship))
                ) && 
                (
                    this.PaymentMethod == input.PaymentMethod ||
                    (this.PaymentMethod != null &&
                    this.PaymentMethod.Equals(input.PaymentMethod))
                ) && 
                (
                    this.Quotation == input.Quotation ||
                    (this.Quotation != null &&
                    this.Quotation.Equals(input.Quotation))
                ) && 
                (
                    this.SenderCurrency == input.SenderCurrency ||
                    (this.SenderCurrency != null &&
                    this.SenderCurrency.Equals(input.SenderCurrency))
                ) && 
                (
                    this.ExchangeRate == input.ExchangeRate ||
                    (this.ExchangeRate != null &&
                    this.ExchangeRate.Equals(input.ExchangeRate))
                ) && 
                (
                    this.LifeTime == input.LifeTime ||
                    (this.LifeTime != null &&
                    this.LifeTime.Equals(input.LifeTime))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.PayedAt == input.PayedAt ||
                    (this.PayedAt != null &&
                    this.PayedAt.Equals(input.PayedAt))
                ) && 
                (
                    this.CancelAt == input.CancelAt ||
                    (this.CancelAt != null &&
                    this.CancelAt.Equals(input.CancelAt))
                ) && 
                (
                    this.CompletedAt == input.CompletedAt ||
                    (this.CompletedAt != null &&
                    this.CompletedAt.Equals(input.CompletedAt))
                ) && 
                (
                    this.InstitutionIcon == input.InstitutionIcon ||
                    (this.InstitutionIcon != null &&
                    this.InstitutionIcon.Equals(input.InstitutionIcon))
                ) && 
                (
                    this.CancelReason == input.CancelReason ||
                    (this.CancelReason != null &&
                    this.CancelReason.Equals(input.CancelReason))
                ) && 
                (
                    this.Intent == input.Intent ||
                    (this.Intent != null &&
                    this.Intent.Equals(input.Intent))
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
                int hashCode = 41;
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.SpeedMode != null)
                    hashCode = hashCode * 59 + this.SpeedMode.GetHashCode();
                if (this.Reference != null)
                    hashCode = hashCode * 59 + this.Reference.GetHashCode();
                if (this.Sku != null)
                    hashCode = hashCode * 59 + this.Sku.GetHashCode();
                if (this.RecipientAccount != null)
                    hashCode = hashCode * 59 + this.RecipientAccount.GetHashCode();
                if (this.Swift != null)
                    hashCode = hashCode * 59 + this.Swift.GetHashCode();
                if (this.Institution != null)
                    hashCode = hashCode * 59 + this.Institution.GetHashCode();
                if (this.SenderName != null)
                    hashCode = hashCode * 59 + this.SenderName.GetHashCode();
                if (this.SenderCountry != null)
                    hashCode = hashCode * 59 + this.SenderCountry.GetHashCode();
                if (this.RecipientName != null)
                    hashCode = hashCode * 59 + this.RecipientName.GetHashCode();
                if (this.RecipientCountry != null)
                    hashCode = hashCode * 59 + this.RecipientCountry.GetHashCode();
                if (this.RecipientRelationship != null)
                    hashCode = hashCode * 59 + this.RecipientRelationship.GetHashCode();
                if (this.PaymentMethod != null)
                    hashCode = hashCode * 59 + this.PaymentMethod.GetHashCode();
                if (this.Quotation != null)
                    hashCode = hashCode * 59 + this.Quotation.GetHashCode();
                if (this.SenderCurrency != null)
                    hashCode = hashCode * 59 + this.SenderCurrency.GetHashCode();
                if (this.ExchangeRate != null)
                    hashCode = hashCode * 59 + this.ExchangeRate.GetHashCode();
                if (this.LifeTime != null)
                    hashCode = hashCode * 59 + this.LifeTime.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.PayedAt != null)
                    hashCode = hashCode * 59 + this.PayedAt.GetHashCode();
                if (this.CancelAt != null)
                    hashCode = hashCode * 59 + this.CancelAt.GetHashCode();
                if (this.CompletedAt != null)
                    hashCode = hashCode * 59 + this.CompletedAt.GetHashCode();
                if (this.InstitutionIcon != null)
                    hashCode = hashCode * 59 + this.InstitutionIcon.GetHashCode();
                if (this.CancelReason != null)
                    hashCode = hashCode * 59 + this.CancelReason.GetHashCode();
                if (this.Intent != null)
                    hashCode = hashCode * 59 + this.Intent.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}