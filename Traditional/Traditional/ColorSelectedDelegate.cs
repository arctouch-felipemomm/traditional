//
// Copyright 2016 ArcTouch LLC.
// All rights reserved.
//
// This file, its contents, concepts, methods, behavior, and operation
// (collectively the "Software") are protected by trade secret, patent,
// and copyright laws. The use of the Software is governed by a license
// agreement. Disclosure of the Software to third parties, in any form,
// in whole or in part, is expressly prohibited except as authorized by
// the license agreement.
//
using System;
using InfColorPickerBinding;
using UIKit;

namespace Traditional
{
	public class ColorSelectedDelegate : InfColorPickerControllerDelegate
	{
		readonly UIViewController parent;

		public ColorSelectedDelegate (UIViewController parent)
		{
			this.parent = parent;
		}

		public override void ColorPickerControllerDidFinish (InfColorPickerController controller)
		{
			parent.View.BackgroundColor = controller.ResultColor;
			parent.DismissViewController (false, null);
		}
	}
}