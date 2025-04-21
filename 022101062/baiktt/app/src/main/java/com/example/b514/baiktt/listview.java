package com.example.b514.baiktt;

import android.widget.ListView;

/**
 * Created by B516 on 4/9/2025.
 */
public class listview {
    private String id;
    private String Name;
    private String gt;
    private String phongban;
    private int stt;

    public String getId() {
        return id;
    }

    public String getName() {
        return Name;
    }

    public String getGt() {
        return gt;
    }

    public String getPhongban() {
        return phongban;
    }

    public void setName(String name) {
        Name = name;
    }

    public void setPhongban(String phongban) {
        this.phongban = phongban;
    }

    public void setGt(String gt) {
        this.gt = gt;

    }

    public listview(int stt,String Id, String Name, String gt, String phongban)
    {
        super();
        this.stt=stt;
        this.id=Id;
        this.Name=Name;
        this.gt=gt;
        this.phongban=phongban;
    }
    public listview(){
        super();

    }
    public  String tostring(){
        return this.id=""+this.Name+""+this.gt+""+this.phongban;
    }

}
