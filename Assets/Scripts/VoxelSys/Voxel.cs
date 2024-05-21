
// RULE: Air comes first, then block types, then non-block types
public struct Voxel
{
	private byte m_Type;

	public static Voxel Air => new(0);
	public static Voxel Stone => new(1);
	public static Voxel Brick => new(2);
	public static Voxel Magic => new(3);
	public static Voxel Dirt => new(4);
	public static Voxel Grass => new(5);
	public static Voxel Object => new(6);

	private Voxel(byte type)
	{
		m_Type = type;
	}

	public static implicit operator byte(Voxel v) => v.m_Type;

	public static implicit operator Voxel(byte b) => new(b);
}