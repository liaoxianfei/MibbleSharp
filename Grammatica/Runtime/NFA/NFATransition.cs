﻿// <copyright file="NFATransition.cs" company="None">
//    <para>
//    This program is free software: you can redistribute it and/or
//    modify it under the terms of the BSD license.</para>
//    <para>
//    This work is distributed in the hope that it will be useful, but
//    WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.</para>
//    <para>
//    See the LICENSE.txt file for more details.</para>
//    Original code as generated by Grammatica 1.6 Copyright (c) 
//    2003-2015 Per Cederberg. All rights reserved.
//    Updates Copyright (c) 2016 Jeremy Gibbons. All rights reserved
// </copyright>

namespace PerCederberg.Grammatica.Runtime.NFA
{
    /// <summary>
    /// An NFA state transition. A transition checks a single
    /// character of input an determines if it is a match. If a match
    /// is encountered, the NFA should move forward to the transition
    /// state.
    /// </summary>
    internal abstract class NFATransition
    {
        /// <summary>
        /// The target state of the transition.
        /// </summary>
        private NFAState state;

        /// <summary>
        /// Initializes a new instance of the <see cref="NFATransition"/> class.
        /// </summary>
        /// <param name="state">The target state</param>
        public NFATransition(NFAState state)
        {
            this.state = state;
            this.state.AddIn(this);
        }

        /// <summary>
        /// Gets a value indicating whether this transition only matches ASCII characters.
        /// I.e. characters with numeric values between 0 and 127.
        /// </summary>
        public abstract bool IsAscii { get; }

        /// <summary>
        /// Gets or sets the target state for this transition
        /// </summary>
        internal NFAState State
        {
            get
            {
                return this.state;
            }

            set
            {
                this.state = value;
            }
        }

        /// <summary>
        /// Checks if the specified character matches the transition.
        /// </summary>
        /// <param name="ch">The character to check</param>
        /// <returns>True if the character matches, false if not</returns>
        public abstract bool Match(char ch);

        /// <summary>
        /// Creates a copy of this transition but with another target
        /// state.
        /// </summary>
        /// <param name="state">The new target state</param>
        /// <returns>An identical copy of this transition</returns>
        public abstract NFATransition Copy(NFAState state);
    }
}
