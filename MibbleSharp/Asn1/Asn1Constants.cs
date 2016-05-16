/*
 * Asn1Constants.cs
 *
 * THIS FILE HAS BEEN GENERATED AUTOMATICALLY. DO NOT EDIT!
 *
 * This work is free software; you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published
 * by the Free Software Foundation; either version 2 of the License,
 * or (at your option) any later version.
 *
 * This work is distributed in the hope that it will be useful, but
 * WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU
 * General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program; if not, write to the Free Software
 * Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA 02111-1307
 * USA
 *
 * Copyright (c) 2004-2009 Per Cederberg. All rights reserved.
 */

/**
 * <remarks>An enumeration with token and production node
 * constants.</remarks>
 */
namespace MibbleSharp.Asn1
{

    internal enum Asn1Constants
    {
        DOT = 1001,
        DOUBLE_DOT = 1002,
        TRIPLE_DOT = 1003,
        COMMA = 1004,
        SEMI_COLON = 1005,
        LEFT_PAREN = 1006,
        RIGHT_PAREN = 1007,
        LEFT_BRACE = 1008,
        RIGHT_BRACE = 1009,
        LEFT_BRACKET = 1010,
        RIGHT_BRACKET = 1011,
        MINUS = 1012,
        LESS_THAN = 1013,
        VERTICAL_BAR = 1014,
        DEFINITION = 1015,
        DEFINITIONS = 1016,
        EXPLICIT = 1017,
        IMPLICIT = 1018,
        TAGS = 1019,
        BEGIN = 1020,
        END = 1021,
        EXPORTS = 1022,
        IMPORTS = 1023,
        FROM = 1024,
        MACRO = 1025,
        INTEGER = 1026,
        REAL = 1027,
        BOOLEAN = 1028,
        NULL = 1029,
        BIT = 1030,
        OCTET = 1031,
        STRING = 1032,
        ENUMERATED = 1033,
        SEQUENCE = 1034,
        SET = 1035,
        OF = 1036,
        CHOICE = 1037,
        UNIVERSAL = 1038,
        APPLICATION = 1039,
        PRIVATE = 1040,
        ANY = 1041,
        DEFINED = 1042,
        BY = 1043,
        OBJECT = 1044,
        IDENTIFIER = 1045,
        INCLUDES = 1046,
        MIN = 1047,
        MAX = 1048,
        SIZE = 1049,
        WITH = 1050,
        COMPONENT = 1051,
        COMPONENTS = 1052,
        PRESENT = 1053,
        ABSENT = 1054,
        OPTIONAL = 1055,
        DEFAULT = 1056,
        TRUE = 1057,
        FALSE = 1058,
        PLUS_INFINITY = 1059,
        MINUS_INFINITY = 1060,
        MODULE_IDENTITY = 1061,
        OBJECT_IDENTITY = 1062,
        OBJECT_TYPE = 1063,
        NOTIFICATION_TYPE = 1064,
        TRAP_TYPE = 1065,
        TEXTUAL_CONVENTION = 1066,
        OBJECT_GROUP = 1067,
        NOTIFICATION_GROUP = 1068,
        MODULE_COMPLIANCE = 1069,
        AGENT_CAPABILITIES = 1070,
        LAST_UPDATED = 1071,
        ORGANIZATION = 1072,
        CONTACT_INFO = 1073,
        DESCRIPTION = 1074,
        REVISION = 1075,
        STATUS = 1076,
        REFERENCE = 1077,
        SYNTAX = 1078,
        BITS = 1079,
        UNITS = 1080,
        ACCESS = 1081,
        MAX_ACCESS = 1082,
        MIN_ACCESS = 1083,
        INDEX = 1084,
        AUGMENTS = 1085,
        IMPLIED = 1086,
        DEFVAL = 1087,
        OBJECTS = 1088,
        ENTERPRISE = 1089,
        VARIABLES = 1090,
        DISPLAY_HINT = 1091,
        NOTIFICATIONS = 1092,
        MODULE = 1093,
        MANDATORY_GROUPS = 1094,
        GROUP = 1095,
        WRITE_SYNTAX = 1096,
        PRODUCT_RELEASE = 1097,
        SUPPORTS = 1098,
        VARIATION = 1099,
        CREATION_REQUIRES = 1100,
        BINARY_STRING = 1101,
        HEXADECIMAL_STRING = 1102,
        QUOTED_STRING = 1103,
        IDENTIFIER_STRING = 1104,
        NUMBER_STRING = 1105,
        WHITESPACE = 1106,
        COMMENT = 1107,
        START = 2001,
        MODULE_DEFINITION = 2002,
        MODULE_IDENTIFIER = 2003,
        MODULE_REFERENCE = 2004,
        TAG_DEFAULT = 2005,
        MODULE_BODY = 2006,
        EXPORT_LIST = 2007,
        IMPORT_LIST = 2008,
        SYMBOLS_FROM_MODULE = 2009,
        SYMBOL_LIST = 2010,
        SYMBOL = 2011,
        ASSIGNMENT_LIST = 2012,
        ASSIGNMENT = 2013,
        MACRO_DEFINITION = 2014,
        MACRO_REFERENCE = 2015,
        MACRO_BODY = 2016,
        MACRO_BODY_ELEMENT = 2017,
        TYPE_ASSIGNMENT = 2018,
        TYPE = 2019,
        DEFINED_TYPE = 2020,
        BUILTIN_TYPE = 2021,
        NULL_TYPE = 2022,
        BOOLEAN_TYPE = 2023,
        REAL_TYPE = 2024,
        INTEGER_TYPE = 2025,
        OBJECT_IDENTIFIER_TYPE = 2026,
        STRING_TYPE = 2027,
        BIT_STRING_TYPE = 2028,
        BITS_TYPE = 2029,
        SEQUENCE_TYPE = 2030,
        SEQUENCE_OF_TYPE = 2031,
        SET_TYPE = 2032,
        SET_OF_TYPE = 2033,
        CHOICE_TYPE = 2034,
        ENUMERATED_TYPE = 2035,
        SELECTION_TYPE = 2036,
        TAGGED_TYPE = 2037,
        TAG = 2038,
        CLASS = 2039,
        EXPLICIT_OR_IMPLICIT_TAG = 2040,
        ANY_TYPE = 2041,
        ELEMENT_TYPE_LIST = 2042,
        ELEMENT_TYPE = 2043,
        OPTIONAL_OR_DEFAULT_ELEMENT = 2044,
        VALUE_OR_CONSTRAINT_LIST = 2045,
        NAMED_NUMBER_LIST = 2046,
        NAMED_NUMBER = 2047,
        NUMBER = 2048,
        CONSTRAINT_LIST = 2049,
        CONSTRAINT = 2050,
        VALUE_CONSTRAINT_LIST = 2051,
        VALUE_CONSTRAINT = 2052,
        VALUE_RANGE = 2053,
        LOWER_END_POINT = 2054,
        UPPER_END_POINT = 2055,
        SIZE_CONSTRAINT = 2056,
        ALPHABET_CONSTRAINT = 2057,
        CONTAINED_TYPE_CONSTRAINT = 2058,
        INNER_TYPE_CONSTRAINT = 2059,
        COMPONENTS_LIST = 2060,
        COMPONENTS_LIST_TAIL = 2061,
        COMPONENT_CONSTRAINT = 2062,
        COMPONENT_VALUE_PRESENCE = 2063,
        COMPONENT_PRESENCE = 2064,
        VALUE_ASSIGNMENT = 2065,
        VALUE = 2066,
        DEFINED_VALUE = 2067,
        BUILTIN_VALUE = 2068,
        NULL_VALUE = 2069,
        BOOLEAN_VALUE = 2070,
        SPECIAL_REAL_VALUE = 2071,
        NUMBER_VALUE = 2072,
        BINARY_VALUE = 2073,
        HEXADECIMAL_VALUE = 2074,
        STRING_VALUE = 2075,
        BIT_OR_OBJECT_IDENTIFIER_VALUE = 2076,
        BIT_VALUE = 2077,
        OBJECT_IDENTIFIER_VALUE = 2078,
        NAME_VALUE_LIST = 2079,
        NAME_VALUE_COMPONENT = 2080,
        NAME_OR_NUMBER = 2081,
        NAME_AND_NUMBER = 2082,
        DEFINED_MACRO_TYPE = 2083,
        DEFINED_MACRO_NAME = 2084,
        SNMP_MODULE_IDENTITY_MACRO_TYPE = 2085,
        SNMP_OBJECT_IDENTITY_MACRO_TYPE = 2086,
        SNMP_OBJECT_TYPE_MACRO_TYPE = 2087,
        SNMP_NOTIFICATION_TYPE_MACRO_TYPE = 2088,
        SNMP_TRAP_TYPE_MACRO_TYPE = 2089,
        SNMP_TEXTUAL_CONVENTION_MACRO_TYPE = 2090,
        SNMP_OBJECT_GROUP_MACRO_TYPE = 2091,
        SNMP_NOTIFICATION_GROUP_MACRO_TYPE = 2092,
        SNMP_MODULE_COMPLIANCE_MACRO_TYPE = 2093,
        SNMP_AGENT_CAPABILITIES_MACRO_TYPE = 2094,
        SNMP_UPDATE_PART = 2095,
        SNMP_ORGANIZATION_PART = 2096,
        SNMP_CONTACT_PART = 2097,
        SNMP_DESCR_PART = 2098,
        SNMP_REVISION_PART = 2099,
        SNMP_STATUS_PART = 2100,
        SNMP_REFER_PART = 2101,
        SNMP_SYNTAX_PART = 2102,
        SNMP_UNITS_PART = 2103,
        SNMP_ACCESS_PART = 2104,
        SNMP_INDEX_PART = 2105,
        INDEX_VALUE_LIST = 2106,
        INDEX_VALUE = 2107,
        INDEX_TYPE = 2108,
        SNMP_DEF_VAL_PART = 2109,
        SNMP_OBJECTS_PART = 2110,
        VALUE_LIST = 2111,
        SNMP_ENTERPRISE_PART = 2112,
        SNMP_VAR_PART = 2113,
        SNMP_DISPLAY_PART = 2114,
        SNMP_NOTIFICATIONS_PART = 2115,
        SNMP_MODULE_PART = 2116,
        SNMP_MODULE_IMPORT = 2117,
        SNMP_MANDATORY_PART = 2118,
        SNMP_COMPLIANCE_PART = 2119,
        COMPLIANCE_GROUP = 2120,
        COMPLIANCE_OBJECT = 2121,
        SNMP_WRITE_SYNTAX_PART = 2122,
        SNMP_PRODUCT_RELEASE_PART = 2123,
        SNMP_MODULE_SUPPORT_PART = 2124,
        SNMP_VARIATION_PART = 2125,
        SNMP_CREATION_PART = 2126
    }
}