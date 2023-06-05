using UnityEngine;

using Averages = PHATASS.Utils.MathUtils.Averages;

namespace PHATASS.Utils.Extensions
{
	//extensions for the UnityEngine.Mesh class
	public static class MeshExtensions
	{
	// Gets the centroid of a mesh (the average of its vertices)
		public static Vector3 EGetCentroid (this Mesh mesh)
		{ return Averages.Vector3ArithmeticAverage(mesh.vertices); }
	}
}
