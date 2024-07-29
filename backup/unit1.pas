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
    cb: TCheckBox;
    ed: TEdit;
    Image1: TImage;
    mm: TMemo;
    procedure Button1Click(Sender: TObject);
  private

  public

  end;

var
  Form1: TForm1;

implementation

{$R *.lfm}

{ TForm1 }

procedure TForm1.Button1Click(Sender: TObject);
begin
  mm.Lines.Add(ed.Text);
  if (cb.Checked=True)
  then
  begin
  mm.Lines.Add('All Rigth');
  end else
    begin
    mm.Lines.Add('Not to-Ru');
    end;
  end;
end;

end.

