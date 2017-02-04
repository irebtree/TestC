using UnityEngine;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlType(TypeName = "menu")]
public class MenuOption{
	[XmlArray("items")]
	public  MenuOptionItem[] items;

	public MenuOptionItem GetOptionItem(MenuConf menu){
		if(items != null) {
			foreach(MenuOptionItem item in items){
				if(menu.Id.Equals(item.MenuId)){
					return item;
				}
			}
		}
		
		return new MenuOptionItem() { MenuId = menu.Id, IsChecked = false };
	}

}
[XmlType(TypeName = "item")]
public class MenuOptionItem{
	[XmlAttribute("menuId")]
	public string MenuId ;
	
	[XmlAttribute("isChecked")]
	public bool IsChecked ;
	
	public override string ToString ()
	{
		return string.Format ("[MenuOptionItem]");
	}
}
