unit Unit1;

{$mode objfpc}{$H+}

interface

uses
  Classes, SysUtils, FileUtil, Forms, Controls, Graphics, Dialogs, StdCtrls,
  ExtCtrls;

type

  { TForm1 }

  TForm1 = class(TForm)
    Button1: TButton;
    chb: TCheckBox;
    cb: TComboBox;
    ed: TEdit;
    Image1: TImage;
    mm: TMemo;
    Panel1: TPanel;
    procedure Button1Click(Sender: TObject);
    procedure chbChange(Sender: TObject);
  private

  public

  end;

var
  Form1: TForm1;

implementation

{$R *.lfm}

{ TForm1 }

procedure TForm1.chbChange(Sender: TObject);
begin
  if (chb.Checked=True) then
  begin
      cb.Visible:=True;
  end                 else
  begin
  cb.Visible:=False;
  end;
end;

procedure TForm1.Button1Click(Sender: TObject);
begin
  mm.Lines.Add(ed.Text+' '+cb.Text);
end;

end.

