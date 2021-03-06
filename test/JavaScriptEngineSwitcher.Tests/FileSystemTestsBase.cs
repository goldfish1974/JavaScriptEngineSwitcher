﻿namespace JavaScriptEngineSwitcher.Tests
{
	using System;
	using System.IO;
	using System.Text.RegularExpressions;

	public abstract class FileSystemTestsBase
	{
		/// <summary>
		/// Regular expression for working with the `bin` directory path
		/// </summary>
		private readonly Regex _binDirRegex = new Regex(@"\\bin\\(?:Debug|Release)\\?$", RegexOptions.IgnoreCase);

		protected string _baseDirectoryPath;


		protected FileSystemTestsBase()
		{
			string baseDirectoryPath = AppDomain.CurrentDomain.BaseDirectory;
			if (_binDirRegex.IsMatch(baseDirectoryPath))
			{
				baseDirectoryPath = Path.GetFullPath(Path.Combine(baseDirectoryPath, @"..\..\..\"));
			}

			_baseDirectoryPath = baseDirectoryPath;
		}
	}
}