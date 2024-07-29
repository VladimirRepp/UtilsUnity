using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UtilsSpace
{
    public static class RandomHelper
    {
        public static Vector3 RangeVector3(Vector3 range)
        {
            Vector3 res;
            res.x = UnityEngine.Random.Range(-range.x, range.x);
            res.y = UnityEngine.Random.Range(-range.y, range.y);
            res.z = UnityEngine.Random.Range(-range.z, range.z);

            return res;
        }

        public static Vector3 RangeVector3(float radius)
        {
            Vector3 res;
            res.x = UnityEngine.Random.Range(-radius, radius);
            res.y = UnityEngine.Random.Range(-radius, radius);
            res.z = UnityEngine.Random.Range(-radius, radius);

            return res;
        }

        public static Vector3 RangeVector3(Vector3 center, float radius)
        {
            return center + RangeVector3(radius);
        }

        public static Vector3 RangeVector3(Vector3 from, Vector3 to)
        {
            Vector3 res;
            res.x = UnityEngine.Random.Range(from.x, to.x);
            res.y = UnityEngine.Random.Range(from.y, to.y);
            res.z = UnityEngine.Random.Range(from.z, to.z);

            return res;
        }

        public static Vector3 RangeVector3(float from, float to, bool isOneValue = true)
        {
            Vector3 res;

            if (isOneValue)
            {
                float randVal = UnityEngine.Random.Range(from, to);
                res.x = randVal;
                res.y = randVal;
                res.z = randVal;
            }
            else
            {
                res.x = UnityEngine.Random.Range(from, to);
                res.y = UnityEngine.Random.Range(from, to);
                res.z = UnityEngine.Random.Range(from, to);
            }

            return res;
        }

    }
}
