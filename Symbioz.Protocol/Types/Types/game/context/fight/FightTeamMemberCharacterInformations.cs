


















// Generated on 06/04/2015 18:45:24
using System;
using System.Collections.Generic;
using System.Linq;
using Symbioz.Utils;

namespace Symbioz.DofusProtocol.Types
{

public class FightTeamMemberCharacterInformations : FightTeamMemberInformations
{

public const short Id = 13;
public override short TypeId
{
    get { return Id; }
}

public string name;
        public byte level;
        

public FightTeamMemberCharacterInformations()
{
}

public FightTeamMemberCharacterInformations(int id, string name, byte level)
         : base(id)
        {
            this.name = name;
            this.level = level;
        }
        

public override void Serialize(ICustomDataOutput writer)
{

base.Serialize(writer);
            writer.WriteUTF(name);
            writer.WriteByte(level);
            

}

public override void Deserialize(ICustomDataInput reader)
{

base.Deserialize(reader);
            name = reader.ReadUTF();
            level = reader.ReadByte();
            if ((level < 0) || (level > 255))
                throw new Exception("Forbidden value on level = " + level + ", it doesn't respect the following condition : (level < 0) || (level > 255)");
            

}


}


}