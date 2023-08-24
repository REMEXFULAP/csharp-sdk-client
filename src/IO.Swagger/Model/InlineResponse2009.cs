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
    /// InlineResponse2009
    /// </summary>
    [DataContract]
    public partial class InlineResponse2009 :  IEquatable<InlineResponse2009>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse2009" /> class.
        /// </summary>
        /// <param name="prepaidCardCombinedBalance">Balance combinado de la tarjeta prepago.</param>
        /// <param name="prepaidCardCombinedBalanceUsd">Balance combinado de la tarjeta prepago en USD.</param>
        /// <param name="referralsCommission">Comisión de referidos.</param>
        /// <param name="usd2mxn">Tasa de cambio de USD a MXN.</param>
        public InlineResponse2009(decimal? prepaidCardCombinedBalance = default(decimal?), decimal? prepaidCardCombinedBalanceUsd = default(decimal?), decimal? referralsCommission = default(decimal?), decimal? usd2mxn = default(decimal?))
        {
            this.PrepaidCardCombinedBalance = prepaidCardCombinedBalance;
            this.PrepaidCardCombinedBalanceUsd = prepaidCardCombinedBalanceUsd;
            this.ReferralsCommission = referralsCommission;
            this.Usd2mxn = usd2mxn;
        }
        
        /// <summary>
        /// Balance combinado de la tarjeta prepago
        /// </summary>
        /// <value>Balance combinado de la tarjeta prepago</value>
        [DataMember(Name="prepaidCardCombinedBalance", EmitDefaultValue=false)]
        public decimal? PrepaidCardCombinedBalance { get; set; }

        /// <summary>
        /// Balance combinado de la tarjeta prepago en USD
        /// </summary>
        /// <value>Balance combinado de la tarjeta prepago en USD</value>
        [DataMember(Name="prepaidCardCombinedBalanceUsd", EmitDefaultValue=false)]
        public decimal? PrepaidCardCombinedBalanceUsd { get; set; }

        /// <summary>
        /// Comisión de referidos
        /// </summary>
        /// <value>Comisión de referidos</value>
        [DataMember(Name="referralsCommission", EmitDefaultValue=false)]
        public decimal? ReferralsCommission { get; set; }

        /// <summary>
        /// Tasa de cambio de USD a MXN
        /// </summary>
        /// <value>Tasa de cambio de USD a MXN</value>
        [DataMember(Name="usd2mxn", EmitDefaultValue=false)]
        public decimal? Usd2mxn { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse2009 {\n");
            sb.Append("  PrepaidCardCombinedBalance: ").Append(PrepaidCardCombinedBalance).Append("\n");
            sb.Append("  PrepaidCardCombinedBalanceUsd: ").Append(PrepaidCardCombinedBalanceUsd).Append("\n");
            sb.Append("  ReferralsCommission: ").Append(ReferralsCommission).Append("\n");
            sb.Append("  Usd2mxn: ").Append(Usd2mxn).Append("\n");
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
            return this.Equals(input as InlineResponse2009);
        }

        /// <summary>
        /// Returns true if InlineResponse2009 instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineResponse2009 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse2009 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PrepaidCardCombinedBalance == input.PrepaidCardCombinedBalance ||
                    (this.PrepaidCardCombinedBalance != null &&
                    this.PrepaidCardCombinedBalance.Equals(input.PrepaidCardCombinedBalance))
                ) && 
                (
                    this.PrepaidCardCombinedBalanceUsd == input.PrepaidCardCombinedBalanceUsd ||
                    (this.PrepaidCardCombinedBalanceUsd != null &&
                    this.PrepaidCardCombinedBalanceUsd.Equals(input.PrepaidCardCombinedBalanceUsd))
                ) && 
                (
                    this.ReferralsCommission == input.ReferralsCommission ||
                    (this.ReferralsCommission != null &&
                    this.ReferralsCommission.Equals(input.ReferralsCommission))
                ) && 
                (
                    this.Usd2mxn == input.Usd2mxn ||
                    (this.Usd2mxn != null &&
                    this.Usd2mxn.Equals(input.Usd2mxn))
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
                if (this.PrepaidCardCombinedBalance != null)
                    hashCode = hashCode * 59 + this.PrepaidCardCombinedBalance.GetHashCode();
                if (this.PrepaidCardCombinedBalanceUsd != null)
                    hashCode = hashCode * 59 + this.PrepaidCardCombinedBalanceUsd.GetHashCode();
                if (this.ReferralsCommission != null)
                    hashCode = hashCode * 59 + this.ReferralsCommission.GetHashCode();
                if (this.Usd2mxn != null)
                    hashCode = hashCode * 59 + this.Usd2mxn.GetHashCode();
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