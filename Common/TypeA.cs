using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    
    // What can we Write Inside The NameSpace?
    // 1- Class
    // 2- Struct ( stande For Structure)
    // 3- Interface
    // 4- Enum
    //--------------------------------------------------
    // Allowed Access Modifier Inside The NameSpace 
    // 1- Internal (Default Access Modifer)
    // 2- Public
    public class TypeA
    {
        #region Definitions
        // What youu can Write Inside The Class Or Struct?
        // 1- Attribute (Filed* Veriables)
        // 2- Property ( FullProperty - Automatic Property - Indexer )
        // 3- Functions ( Constructor - Getter/Setter - Method )
        // 4- Event
        //------------------------------------------
        // Allowed Access Modifier Inside The Struct
        // 1- Private
        // 2- Internal
        // 3- Public
        //------------------------------------------
        // Allowed Access Modifier Inside The Class
        // 1- Private
        // 2- Private Protected 
        // 3- Protected
        // 4- Internal
        // 5- Internal Protected
        // 6- Public
        //------------------------------------------
        // What you can Write Inside InterFace?
        // 1- Signature For Property
        // 2- Signature For Method
        // 3- Default Impelmented Method
        //----------------------
        // Default Access Modifer Inside The Interface Is Public
        #endregion

        /*private*/
        int x; // Default Access Modifer
        internal int y;
        public int z;
    }
}
