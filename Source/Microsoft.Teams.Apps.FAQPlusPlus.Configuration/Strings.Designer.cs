﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Teams.Apps.FAQPlusPlus.Configuration {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Strings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.Teams.Apps.FAQPlusPlus.Configuration.Strings", typeof(Strings).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Hola, soy tu amigable Bot de preguntas y respuestas. Puedes hacerme preguntas y haré todo lo posible para responder. Si no puedo ayudar, te conectaré con un experto.
        ///
        ///Mis características principales:
        ///
        ///* Haz una pregunta, obtén una respuesta
        ///* Pregunta a un experto
        ///* Compartir comentarios.
        /// </summary>
        public static string DefaultHelpTabText {
            get {
                return ResourceManager.GetString("DefaultHelpTabText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Hola, soy tu amigable Bot de preguntas y respuestas. Puedes hacerme preguntas y haré todo lo posible para responder. Si no puedo ayudar, te conectaré con un experto.
        ///
        ///Puede hacer las siguientes preguntas:
        ///* ¿Como trabajas?
        ///* ¿Qué beneficios hay disponibles?
        ///* ¿Qué cosas están disponibles aquí ahora mismo?.
        /// </summary>
        public static string DefaultWelcomeMessage {
            get {
                return ResourceManager.GetString("DefaultWelcomeMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Proporcione el texto que se mostrará en la pestaña Ayuda del Bot y luego haga clic en Aceptar para agregar o Editar para modificar.
        /// </summary>
        public static string HelpTabTextToolTipHoverMessage {
            get {
                return ResourceManager.GetString("HelpTabTextToolTipHoverMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Proporcione un ID de base de conocimiento válido que será utilizado por el Bot y luego haga clic en Aceptar para agregar o Editar para modificar.
        /// </summary>
        public static string KnowledgeBaseToolTipHoverMessage {
            get {
                return ResourceManager.GetString("KnowledgeBaseToolTipHoverMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Grabar conversaciones.
        /// </summary>
        public static string SaveConversationsToolTipHoverMessage {
            get {
                return ResourceManager.GetString("SaveConversationsToolTipHoverMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Proporcione un enlace del equipo Teams que será utilizado por el Bot y luego haga clic en Aceptar para agregar o Editar para modificar.
        /// </summary>
        public static string TeamIdToolTipHoverMessage {
            get {
                return ResourceManager.GetString("TeamIdToolTipHoverMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Proporcione un mensaje de bienvenida que será utilizado por el Bot y luego haga clic en Aceptar para agregar o Editar para modificar.
        /// </summary>
        public static string WelcomeMessageToolTipHoverMessage {
            get {
                return ResourceManager.GetString("WelcomeMessageToolTipHoverMessage", resourceCulture);
            }
        }
    }
}
