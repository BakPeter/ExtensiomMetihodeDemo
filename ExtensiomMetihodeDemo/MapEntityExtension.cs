namespace ExtensiomMetihodeDemo;
internal static class MapEntityExtension
{
    public static void MoveDeg(this MapEntity entity, int deg)
    {
        entity.X += deg;
        entity.Y += deg;
    }
}
