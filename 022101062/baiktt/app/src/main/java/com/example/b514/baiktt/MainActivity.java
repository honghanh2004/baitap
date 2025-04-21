package com.example.b514.baiktt;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ListView;
import android.widget.RadioButton;
import android.widget.Spinner;
import android.widget.SpinnerAdapter;

import java.lang.reflect.Array;
import java.util.ArrayList;
import java.util.List;
import java.util.StringTokenizer;

public class MainActivity extends AppCompatActivity {
    EditText txtmanv,txttennv;
    RadioButton rdnam,rdnu;
    Spinner spphongban;
    ListView lsthienthi;
    Button btnhap;
    ArrayList<String>ArrSpinner= new ArrayList<String>();
    ArrayAdapter<String> adapterSpinner= null;

    ArrayList<ListView>arrayListView= new ArrayList<ListView>();
    ArrayAdapter<ListView> adapterListView= null;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        getWidegetsControl();
    }
    private void getWidegetsControl()
    {
        txtmanv=(EditText) findViewById(R.id.txtmanv);
        txttennv=(EditText) findViewById(R.id.txttennv);
        rdnam=(RadioButton) findViewById(R.id.rdnam);
        rdnu=(RadioButton) findViewById(R.id.rdNu);
        spphongban=(Spinner) findViewById(R.id.spphongban);
        lsthienthi=(ListView) findViewById(R.id.lsthienthi);
        btnhap=(Button) findViewById(R.id.btnhap);

        adapterSpinner= new ArrayAdapter<String>(this, android.R.layout.simple_spinner_item,ArrSpinner);
        adapterSpinner.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item);

        adapterListView= new ArrayAdapter<ListView>(this,android.R.layout.simple_list_item_1,arrayListView);
        lsthienthi.setAdapter(adapterListView);



    }
    private void DataCatalog(){
        ArrSpinner.add("Kế Toán");
        ArrSpinner.add("Marketting");
        ArrSpinner.add("Nhân sự");
        adapterSpinner.notifyDataSetChanged();
    }

    private void Nhap(){
        int stt= arrayListView.size();
        String manv= txtmanv.getText().toString();
        String tennv=txttennv.getText().toString();
        String gt=rdnam.isChecked()?"Nam":"Nữ";
        String phongban=spphongban.getSelectedItem().toString();
        ListView lv= new ListView(stt,manv,tennv,gt,phongban);
    }
    private void addEvent(){
        btnhap.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {

            }
        });
    }
}
