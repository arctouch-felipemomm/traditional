//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using UIKit;
using GLKit;
using Metal;
using MapKit;
using ModelIO;
using Security;
using SceneKit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using NewsstandKit;
using CoreAnimation;
using CoreFoundation;

namespace InfColorPickerBinding {
	[Register("InfColorSquareView", true)]
	public unsafe partial class InfColorSquareView : global::UIKit.UIImageView {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("InfColorSquareView");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public InfColorSquareView () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[CompilerGenerated]
		[DesignatedInitializer]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public InfColorSquareView (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;

			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected InfColorSquareView (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal InfColorSquareView (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		public virtual float Hue {
			[Export ("hue")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("hue"));
				} else {
					return global::ApiDefinition.Messaging.float_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("hue"));
				}
			}
			
			[Export ("setHue:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setHue:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, Selector.GetHandle ("setHue:"), value);
				}
			}
		}
		
		public partial class InfColorSquareViewAppearance : global::UIKit.UIImageView.UIImageViewAppearance {
			protected internal InfColorSquareViewAppearance (IntPtr handle) : base (handle) {}
		}
		
		public static new InfColorSquareViewAppearance Appearance {
			get { return new InfColorSquareViewAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, ObjCRuntime.Selector.GetHandle ("appearance"))); }
		}
		
		public static new InfColorSquareViewAppearance GetAppearance<T> () where T: InfColorSquareView {
			return new InfColorSquareViewAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (Class.GetHandle (typeof (T)), ObjCRuntime.Selector.GetHandle ("appearance")));
		}
		
		public static new InfColorSquareViewAppearance AppearanceWhenContainedIn (params Type [] containers)
		{
			return new InfColorSquareViewAppearance (UIAppearance.GetAppearance (class_ptr, containers));
		}
		
		public static new InfColorSquareViewAppearance GetAppearance (UITraitCollection traits) {
			return new InfColorSquareViewAppearance (UIAppearance.GetAppearance (class_ptr, traits));
		}
		
		public static new InfColorSquareViewAppearance GetAppearance (UITraitCollection traits, params Type [] containers) {
			return new InfColorSquareViewAppearance (UIAppearance.GetAppearance (class_ptr, traits, containers));
		}
		
		public static new InfColorSquareViewAppearance GetAppearance<T> (UITraitCollection traits) where T: InfColorSquareView {
			return new InfColorSquareViewAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), traits));
		}
		
		public static new InfColorSquareViewAppearance GetAppearance<T> (UITraitCollection traits, params Type [] containers) where T: InfColorSquareView{
			return new InfColorSquareViewAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), containers));
		}
		
		
	} /* class InfColorSquareView */
}
