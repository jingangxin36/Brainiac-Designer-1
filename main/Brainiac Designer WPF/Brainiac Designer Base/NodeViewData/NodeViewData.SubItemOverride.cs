////////////////////////////////////////////////////////////////////////////////////////////////////
// Copyright (c) 2009, Daniel Kollmann
// All rights reserved.
//
// Redistribution and use in source and binary forms, with or without modification, are permitted
// provided that the following conditions are met:
//
// - Redistributions of source code must retain the above copyright notice, this list of conditions
//   and the following disclaimer.
//
// - Redistributions in binary form must reproduce the above copyright notice, this list of
//   conditions and the following disclaimer in the documentation and/or other materials provided
//   with the distribution.
//
// - Neither the name of Daniel Kollmann nor the names of its contributors may be used to endorse
//   or promote products derived from this software without specific prior written permission.
//
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND ANY EXPRESS OR
// IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND
// FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT OWNER OR
// CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL
// DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE,
// DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY,
// WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY
// WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Media;
using Brainiac.Design.Nodes;
using Brainiac.Design.Attachments.Overrides;

namespace Brainiac.Design
{
	public partial class NodeViewData
	{
		/// <summary>
		/// A subitem used to visualise overrides on a node.
		/// </summary>
		public class SubItemOverride : SubItemAttachment
		{
			private static readonly SolidColorBrush _theDefaultOverrideBrush= new SolidColorBrush(Color.FromArgb(50, 0, 0, 0));
			private static readonly SolidColorBrush _theSelectedOverrideBrush= new SolidColorBrush(Color.FromArgb(100, 0, 0, 0));
			private static readonly Font _theOverrideLabelFont= new Font("Calibri,Arial", false, 6.0);

			/// <summary>
			/// Creates a new subitm which can render an override on the node.
			/// </summary>
			/// <param name="overr">The override we want to draw.</param>
			public SubItemOverride(Override overr) : base(overr, _theDefaultOverrideBrush, _theSelectedOverrideBrush, _theOverrideLabelFont, Brushes.LightGray)
			{
			}

			public override SubItem Clone(Node newnode)
			{
				return new SubItemOverride( (Override)_attachment.Clone(newnode) );
			}
		}
	}
}
