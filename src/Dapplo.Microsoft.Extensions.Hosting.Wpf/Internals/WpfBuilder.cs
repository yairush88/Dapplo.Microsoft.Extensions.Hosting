// Dapplo - building blocks for desktop applications
// Copyright (C) 2019 Dapplo
// 
// For more information see: http://dapplo.net/
// Dapplo repositories are hosted on GitHub: https://github.com/dapplo
// 
// This file is part of Dapplo.Hosting.Samples
// 
// Dapplo.Hosting.Samples is free software: you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// Dapplo.Hosting.Samples is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Lesser General Public License for more details.
// 
// You should have a copy of the GNU Lesser General Public License
// along with Dapplo.Hosting.Samples. If not, see <http://www.gnu.org/licenses/lgpl.txt>.
// 

using System.Windows;

namespace Dapplo.Microsoft.Extensions.Hosting.Wpf.Internals
{
    /// <inheritdoc />
    public class WpfBuilder : IWpfBuilder
    {
        /// <inheritdoc />
        public Application WpfApplication { get; } = new Application
        {
            // Default value
            ShutdownMode = ShutdownMode.OnLastWindowClose
        };
    }
}