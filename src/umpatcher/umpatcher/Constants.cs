﻿/*
    Copyright (C) 2018 de4dot@gmail.com

    This file is part of umpatcher

    umpatcher is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    umpatcher is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with umpatcher.  If not, see <http://www.gnu.org/licenses/>.
*/

using System;

namespace UnityMonoDllSourceCodePatcher {
	static class Constants {
		public const string DnSpyUnityRepo_master_Branch = "master";
		public const string DnSpyUnityRepo_dnSpy_Branch = "dnSpy";
		public const string UnityVersionPrefix = "unity-";
		public const string ReadMeFilename = "README.md";
		public const string SolutionFilename = "dnSpy-Unity-mono.sln";
		public static readonly string[] unityFoldersToCopy = new string[] {
			"eglib",
			"libgc",
			"mono",
			"msvc",
			"unity",
		};

		public static readonly string[] VersionTableHeaderLines = new string[] {
			"version | git hash",
			"--------|---------",
		};
		public const string VersionTableEndLine = "";

		public const string Solution_ProjectConfigurationPlatforms_Line = "\tGlobalSection(ProjectConfigurationPlatforms) = postSolution";
		public const string Solution_NestedProjects_Line = "\tGlobalSection(NestedProjects) = preSolution";
		public const string Solution_EndGlobalSection_Line = "\tEndGlobalSection";
		public static readonly string[] SolutionConfigurations = new string[] {
			"Debug_eglib",
			"Debug",
			"Release_eglib_xarm",
			"Release_eglib",
			"Release",
		};
		public static readonly (string archName, string configName)[] SolutionPlatforms = new(string, string)[] {
			("x64", "x64"),
			("x86", "Win32"),
		};
		public static readonly string[] SolutionBuildInfos = new string[] {
			"ActiveCfg",
			"Build.0",
		};

		public static readonly string[] ReleaseConfigsWithNoPdb = new string[] {
			"Release_eglib|Win32",
			"Release_eglib|x64",
		};

		public const string OldProjectToolsVersion = "ToolsVersion=\"4.0\"";
		public const string NewProjectToolsVersion = "ToolsVersion=\"15.0\"";

		public static readonly Guid OldGuid_eglib = new Guid("158073ED-99AE-4196-9EDC-DDB2344F8466");
		public static readonly Guid OldGuid_genmdesc = new Guid("B7098DFA-31E6-4006-8A15-1C9A4E925149");
		public static readonly Guid OldGuid_libgc = new Guid("EB56000B-C80B-4E8B-908D-D84D31B517D3");
		public static readonly Guid OldGuid_libmono = new Guid("CB0D9E92-293C-439C-9AC7-C5F59B6E0771");

		public const string DefaultWindowsTargetPlatformVersion = "10.0.16299.0";
		public const string DefaultPlatformToolset = "v141";

		public const string OldWinVer = "0x0500";
		public const string NewWinVer = "0x0501";

		public const string GitCleanTreeMessage = "nothing to commit, working tree clean";
	}
}
