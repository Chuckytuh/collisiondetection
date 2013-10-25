//Method based on XNA
public float? Intersects(Rectangle rectangle, Ray ray)  
        {  
            float num = 0f;  
            float maxValue = float.MaxValue;  
            if (Math.Abs(ray.Direction.X) < 1E-06f)  
            {  
                if ((ray.Position.X < rectangle.Left) || (ray.Position.X > rectangle.Right))  
                {  
                    return null;  
                }  
            }  
            else 
            {  
                float num11 = 1f / ray.Direction.X;  
                float num8 = (rectangle.Left - ray.Position.X) * num11;  
                float num7 = (rectangle.Right - ray.Position.X) * num11;  
                if (num8 > num7)  
                {  
                    float num14 = num8;  
                    num8 = num7;  
                    num7 = num14;  
                }  
                num = MathHelper.Max(num8, num);  
                maxValue = MathHelper.Min(num7, maxValue);  
                if (num > maxValue)  
                {  
                    return null;  
                }  
            }  
            if (Math.Abs(ray.Direction.Y) < 1E-06f)  
            {  
                if ((ray.Position.Y < rectangle.Top) || (ray.Position.Y > rectangle.Bottom))  
                {  
                    return null;  
                }  
            }  
            else 
            {  
                float num10 = 1f / ray.Direction.Y;  
                float num6 = (rectangle.Top - ray.Position.Y) * num10;  
                float num5 = (rectangle.Bottom - ray.Position.Y) * num10;  
                if (num6 > num5)  
                {  
                    float num13 = num6;  
                    num6 = num5;  
                    num5 = num13;  
                }  
                num = MathHelper.Max(num6, num);  
                maxValue = MathHelper.Min(num5, maxValue);  
                if (num > maxValue)  
                {  
                    return null;  
                }  
            }  
 
            return new float?(num);  
        } 
