using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyRPG.roles
{
    internal interface IRole
    {
        string Name { get; }
        ICharacter Self { get; set; }
        void ChangeState(IRole defender);
        void Attack(IRole defender);
    }
}
