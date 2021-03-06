﻿// <copyright file="SnmpAgentCapabilities.cs" company="None">
//    <para>
//    This work is free software; you can redistribute it and/or modify
//    it under the terms of the GNU General Public License as published
//    by the Free Software Foundation; either version 2 of the License,
//    or (at your option) any later version.</para>
//    <para>
//    This work is distributed in the hope that it will be useful, but
//    WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU
//    General Public License for more details.</para>
//    <para>
//    You should have received a copy of the GNU General Public License
//    along with this program; if not, write to the Free Software
//    Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA 02111-1307
//    USA</para>
//    Original Java code Copyright (c) 2004-2016 Per Cederberg. All
//    rights reserved.
//    C# conversion Copyright (c) 2016 Jeremy Gibbons. All rights reserved
// </copyright>

namespace MibbleSharp.Snmp
{
    using System.Collections.Generic;
    using System.Text;
    using MibbleSharp.Value;

    /// <summary>
    /// The SNMP agent capabilities macro type. This macro type was added
    /// to SMIv2 and is defined in RFC 2580.
    /// </summary>
    /// <see href="http://www.ietf.org/rfc/rfc2580.txt">RFC 2580 (SNMPv2-CONF)</see>
    public class SnmpAgentCapabilities : SnmpType
    {
        /// <summary>The product release.</summary>
        private string productRelease;

        /// <summary>The type status.</summary>
        private SnmpStatus status;

        /// <summary>The type reference.</summary>
        private string reference;

        /// <summary>The list of supported modules.</summary> 
        private IList<SnmpModuleSupport> modules;

        /// <summary>
        /// Initializes a new instance of the <see cref="SnmpAgentCapabilities"/> class.
        /// </summary>
        /// <param name="productRelease">The product release</param>
        /// <param name="status">The type status</param>
        /// <param name="description">The type description</param>
        /// <param name="reference">The type reference or null</param>
        /// <param name="modules">The list of supported modules</param>
        public SnmpAgentCapabilities(
            string productRelease,
            SnmpStatus status,
            string description,
            string reference,
            IList<SnmpModuleSupport> modules)
            : base("AGENT-CAPABILITIES", description)
        {
            this.productRelease = productRelease;
            this.status = status;
            this.reference = reference;
            this.modules = modules;
        }

        /// <summary>Gets the product release.</summary>
        public string ProductRelease
        {
            get
            {
                return this.productRelease;
            }
        }

        /// <summary>
        /// Gets the type status
        /// </summary>
        public SnmpStatus Status
        {
            get
            {
                return this.status;
            }
        }

        /// <summary>
        /// Gets the type reference
        /// </summary>
        public string Reference
        {
            get
            {
                return this.reference;
            }
        }

        /// <summary>
        /// Gets the list of the supported modules. The returned list
        /// will consist of <c>SnmpModuleSupport</c> instances.
        /// </summary>
        /// <see cref="SnmpModuleSupport"/>
        public IEnumerable<SnmpModuleSupport> Modules
        {
            get
            {
                return this.modules;
            }
        }

        /// <summary>
        /// Initializes the MIB type. This will remove all levels of
        /// indirection present, such as references to types or values. No
        /// information is lost by this operation. This method may modify
        /// this object as a side-effect, and will return the basic type.
        /// Note: This is an internal method that should
        /// only be called by the MIB loader.
        /// </summary>
        /// <param name="symbol">The MIB symbol containing this type</param>
        /// <param name="log">The MIB loader log</param>
        /// <returns>The basic MIB type</returns>
        /// <exception cref="MibException">
        /// If an error is encountered during initialization
        /// </exception>
        public override MibType Initialize(MibSymbol symbol, MibLoaderLog log)
        {
            if (!(symbol is MibValueSymbol))
            {
                throw new MibException(
                    symbol.Location,
                    "only values can have the " + this.Name + " type");
            }

            foreach (var m in this.modules)
            {
                m.Initialize(log);
            }

            return this;
        }

        /// <summary>
        /// Checks if the specified value is compatible with this type. A
        /// value is compatible if and only if it is an object identifier
        /// value.
        /// </summary>
        /// <param name="value">The value to be checked</param>
        /// <returns>
        /// True if they are compatible, i.e. the value is an 
        /// ObjectIdentifierValue, false if not
        /// </returns>
        public override bool IsCompatible(MibValue value)
        {
            return value is ObjectIdentifierValue;
        }

        /// <summary>
        /// Returns a string representation of this object.
        /// </summary>
        /// <returns>A string representation of this object.</returns>
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder.Append(base.ToString());
            builder.Append(" (");
            builder.Append("\n  Product Release: ");
            builder.Append(this.productRelease);
            builder.Append("\n  Status: ");
            builder.Append(this.status);
            builder.Append("\n  Description: ");
            builder.Append(this.GetDescription("               "));

            if (this.reference != null)
            {
                builder.Append("\n  Reference: ");
                builder.Append(this.reference);
            }

            foreach (var m in this.modules)
            {
                builder.Append("\n  Supports Module: ");
                builder.Append(m);
            }

            builder.Append("\n)");
            return builder.ToString();
        }
    }
}
