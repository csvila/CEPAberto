﻿// ***********************************************************************
// Assembly         : CEPAberto
// Author           : Guilherme Branco Stracini
// Created          : 2018-08-15
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 06-28-2020
// ***********************************************************************
// <copyright file="PostalCodeRequest.cs" company="Guilherme Branco Stracini ME">
//     Copyright © 2020
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace CEPAberto.Transport
{
    using Attributes;

    /// <summary>
    /// The postal code request class.
    /// </summary>
    [RequestEndPoint("cep?cep={PostalCode}")]
    public sealed class PostalCodeRequest : BaseRequest
    {
        /// <summary>
        /// Gets or sets the postal code.
        /// </summary>
        /// <value>The postal code.</value>
        public string PostalCode { get; set; }
    }
}
