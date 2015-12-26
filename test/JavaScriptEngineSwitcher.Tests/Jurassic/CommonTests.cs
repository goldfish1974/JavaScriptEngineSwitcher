﻿namespace JavaScriptEngineSwitcher.Tests.Jurassic
{
	using Core;

	public class CommonTests : CommonTestsBase
	{
		protected override IJsEngine CreateJsEngine()
		{
			var jsEngine = JsEngineSwitcher.Current.CreateJsEngineInstance("JurassicJsEngine");

			return jsEngine;
		}
	}
}