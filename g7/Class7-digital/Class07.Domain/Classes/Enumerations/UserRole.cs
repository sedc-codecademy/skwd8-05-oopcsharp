using System;
using System.Collections.Generic;
using System.Text;

// I separated the enumerations and classes so I can colapse the enumerations ( they are not changed very often )
// I will use the same namespace because when I call them I want all of them to come in the same package
// This is a individual decision of the developer
namespace Class07.Domain.Classes
{
	public enum UserRole
	{
		// I am not adding a default value
		// I want default to be Standard
		Administrator,
		Standard
	}
}
