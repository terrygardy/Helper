using System;
using System.Reflection;

namespace Helpers.Mapping
{
	public static class Mapping
	{
		public static void mapObject<T, S>(T pr_objTarget, S pv_objSource)
			where T : class
			where S : class
		{
			PropertyInfo[] arrProperties;
			Type tSource = typeof(S);

			//if (pr_objTarget == null) pr_objTarget = new T();

			arrProperties = pr_objTarget.GetType().GetProperties();

			foreach (PropertyInfo piTarget in arrProperties)
			{
				try
				{
					PropertyInfo piSource = tSource.GetProperty(piTarget.Name);

					if (piSource != null)
					{
						object objValue = piSource.GetValue(pv_objSource);

						if (objValue != null) piTarget.SetValue(pr_objTarget, objValue);
					}
				}
				catch (Exception ex)
				{
					Console.WriteLine("Mapping error: Source = " + tSource.ToString() + ", Target = " + pr_objTarget.GetType().ToString() + ", error = " + ex.InnerException.Message);
				}
			}
		}
	}
}
